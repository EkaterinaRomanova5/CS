using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Game
    {
        private readonly NumberGenerator _numberGenerator;
        private readonly InputService _inputService;
        private readonly OutputService _outputService;
        private int _targetNumber;

        public Game(NumberGenerator numberGenerator, InputService inputService, OutputService outputService)
        {
            _numberGenerator = numberGenerator;
            _inputService = inputService;
            _outputService = outputService;
        }

        public void Start()
        {
            _targetNumber = _numberGenerator.Generate(1, 100);
            int guess;
            do
            {
                guess = _inputService.GetInput();
                if (guess < _targetNumber)
                {
                    _outputService.Print("Загаданное число больше.");
                }
                else if (guess > _targetNumber)
                {
                    _outputService.Print("Загаданное число меньше.");
                }
                else
                {
                    _outputService.Print("Поздравляю, Вы угадали число!");
                }
            } while (guess != _targetNumber);
        }
    }
}
