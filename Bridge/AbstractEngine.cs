﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class AbstractEngine :IEngine
    {
        private int size;
        private bool turbo;
        private bool running;
        private int power;

        public AbstractEngine(int size, bool turbo) {
            this.size = size;
            this.turbo = turbo;
            running = false;
            power = 0;
        }

        public virtual int Size {
            get {
                return size;
            }
        }

        public virtual bool Turbo {
            get {
                return turbo;
            }
        }

        public virtual void Start() {
            running = true;
        }

        public virtual void Stop() {
            running = false;
            power = 0;
        }

        public virtual void IncreasePower() {
            if ((running) && (power < 10)) {
                power++;
            }
        }

        public virtual void DecreasePower() {
            if ((running) && (power > 0)) {
                power--;
            }
        }

        public override string ToString()
        {
            return this.GetType().Name + "(" + size + ")";
        }


    }
}
