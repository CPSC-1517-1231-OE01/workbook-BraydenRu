using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace TrainSystem
{
    public class Engine
    {
        private string _model;
        private string _serialNumber;
        private bool _inService;
        private int _weight;
        private int _horsePower;
        
        public Engine(string model, string serialNumber,int weight, int horsePower)
        {
            _model = model;
            _serialNumber = serialNumber;
            _inService = true;
            _weight = weight;
            _horsePower = horsePower;
            
        }

        public string Model
        {
            get
            {
                return _model;
            }
            private set
            {
                if(Utilities.IsNullEmptyOrWhiteSpace(value))
                {
                    throw new ArgumentException("The trains engine model must not be blank");
                }

                string modelValue = value;
                char[] trimWhiteSpace = { ' ' };
                modelValue = modelValue.Trim(trimWhiteSpace);

                _model = modelValue;

            }
        }
        public string SerialNumber
        {
            get
            {
                return _serialNumber;

            }
            private set
            {
                if (Utilities.IsNullEmptyOrWhiteSpace(value))
                {
                    throw new ArgumentException("The trains engine serial number must not be blank");
                }
         
                string serialValue = value;
                char[] trimWhiteSpace = {' '};
                serialValue = serialValue.Trim(trimWhiteSpace); 

                _serialNumber = serialValue;

            }
        }

    }
}

