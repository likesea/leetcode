using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeBiz.Queue
{
    public class GasStation
    {
        /// <summary>
        /// 总长度
        /// </summary>
        private int _length;
        /// <summary>
        /// 初始汽油
        /// </summary>
        private int _initialGas;
        /// <summary>
        /// 加油站点
        /// </summary>
        private List<int> _stations;
        /// <summary>
        /// 加油站点油量
        /// </summary>
        private List<int> _stationGas;

        private int _gasNum;
        public GasStation(int length, int initialGas, int[] station, int[] stationGas)
        {
            _length = length;
            _initialGas = initialGas;
            _stations = station.ToList();
            _stationGas = stationGas.ToList();
            _gasNum = station.Length;
        }

        public int Solve()
        {
            int addGasNum = 0;
            int currentGas = _initialGas;
            //方便考虑把终点看出没有油的加油站
            _stations.Add(_length);
            _stationGas.Add(0);
            PriorityQueue<int> queue = new PriorityQueue<int>();
            for (int i = 0; i < _gasNum+1; i++)
            {
                while (currentGas < _stations[i])
                {
                    if (queue.IsEmpty())
                    {
                        return -1;
                    }
                    currentGas += queue.Top();
                    queue.Remove(queue.Top());
                    addGasNum++;
                }
                queue.Add(_stationGas[i]);
            }
            return addGasNum;
        }
    }
}
