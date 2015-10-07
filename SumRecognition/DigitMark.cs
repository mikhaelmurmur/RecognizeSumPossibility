using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumRecognition
{
    public class DigitMark
    {
        public byte currentNumber { get; private set; }
        public bool available { get; set; }
        List<DigitMark> connections = new List<DigitMark>();
        public DigitMark()
        {
            throw new InvalidOperationException("Created digit mark withour number inputed");
        }

        public DigitMark(byte number)
        {
            currentNumber = number;
        }

        public void AddConnection(DigitMark newConnection)
        {
            connections.Add(newConnection);
        }

        public void DeleteConnection(DigitMark connectionToDelete)
        {
            if (connections.Contains(connectionToDelete))
            {
                connections.Remove(connectionToDelete);
            }
        }

        public bool ConnectedTo(DigitMark connectedNode)
        {
            return connections.Contains(connectedNode);
        }
    }
}
