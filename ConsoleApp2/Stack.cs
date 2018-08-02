using System;

namespace StackExample
{
    class Stack
    {
        private object[] _objectHolder = null;

        /**
         * Push item into stack
         * Last in
         */
        public void Push(object item)
        {
            var downItem = (object)item;

            if (this._objectHolder?.Length == null)
            {
                this._objectHolder = new object[1];
                this._objectHolder[0] = downItem;
            } else
            {
                var buffer = new object[this._objectHolder.Length];

                for (var i = 0; i < this._objectHolder.Length; i++)
                    buffer[i] = this._objectHolder[i];

                this._objectHolder = new object[buffer.Length + 1];

                for (var i = 0; i < buffer.Length; i++)
                    this._objectHolder[i] = buffer[i];

                this._objectHolder[this._objectHolder.Length - 1] = downItem;
            }
        }

        /**
         *  Delete item from stack
         *  First out
         */
        public object Pop()
        {
            if (this._objectHolder.Length == 0)
                throw new Exception("Stack is not initialized!");

            var buffer = new object[this._objectHolder.Length - 1];

            for (var i = 0; i < buffer.Length; i++)
                buffer[i] = this._objectHolder[i];

            var poped = this._objectHolder[this._objectHolder.Length - 1];

            this._objectHolder = new object[buffer.Length];

            for (var i = 0; i < this._objectHolder.Length; i++)
                this._objectHolder[i] = buffer[i];

            return poped;
        }

        public string Clear()
        {
            if(this._objectHolder?.Length == null)
            {
                return "Stack is emtpy already.";
            }
            else
            {
                this._objectHolder = new object[0];
                return "Stack has been cleared.";
            }
        }
    }
}
