using Engine.Enums;
using Engine.Services;

var inputService = new WinInputService();

Thread.Sleep(1000);

inputService.LeftClick(100, 100);

inputService.HoldButton(InputButtons.LeftShift);
inputService.PressButton(InputButtons.T);
inputService.PressButton(InputButtons.E);
inputService.PressButton(InputButtons.X);
inputService.PressButton(InputButtons.T);
inputService.PressButton(InputButtons.Space);
inputService.PressButton(InputButtons.T);
inputService.PressButton(InputButtons.O);
inputService.PressButton(InputButtons.Space);
inputService.PressButton(InputButtons.C);
inputService.PressButton(InputButtons.O);
inputService.PressButton(InputButtons.P);
inputService.PressButton(InputButtons.Y);
inputService.ReleaseButton(InputButtons.LeftShift);

inputService.PressButtons(InputButtons.Control, InputButtons.A);
inputService.PressButtons(InputButtons.Control, InputButtons.C);
inputService.PressButton(InputButtons.RightArrow);
inputService.PressButton(InputButtons.Enter);
inputService.PressButtons(InputButtons.Control, InputButtons.V);
