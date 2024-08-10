using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim
{
    public enum ButtonAction : byte
    {
        None,
        Click,
        DoubleClick,
        LongPress
    }

    public enum RotaryAction : byte
    {
        None,
        Increment,
        Decrement
    }

    public class ArduinoMessage
    {
        /// <summary>
        /// Gets or sets the button number.
        /// </summary>
        /// <remarks>32-bit signed.</remarks>
        public int ButtonNumber { get; set; }

        /// <summary>
        /// Gets or sets the button action.
        /// </summary>
        /// <remarks>8-bit unsigned.</remarks>
        public ButtonAction ButtonAction { get; set; }

        /// <summary>
        /// Gets or sets the rotary encoder action.
        /// </summary>
        /// <remarks>8-bit unsigned.</remarks>
        public RotaryAction RotaryAction { get; set; }

        public ArduinoMessage()
        {
            ButtonNumber = -1;
            ButtonAction = ButtonAction.None;
            RotaryAction = RotaryAction.None;
        }

        /// <summary>
        /// Converts the message to a byte array.
        /// </summary>
        /// <returns>Returns the message as a byte array.</returns>
        public byte[] ToBytes()
        {
            byte[] buffer = new byte[6];
            var btnNumberBytes = BitConverter.GetBytes(ButtonNumber);
            btnNumberBytes.CopyTo(buffer, 0);
            buffer[4] = (byte)ButtonAction;
            buffer[5] = (byte)RotaryAction;
            return buffer;
        }
    }
}
