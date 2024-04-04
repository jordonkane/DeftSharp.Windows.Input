﻿using DeftSharp.Windows.Input.Shared.Abstraction.Interceptors;
using DeftSharp.Windows.Input.Shared.Delegates;

namespace DeftSharp.Windows.Input.Mouse;

internal interface INativeMouseInterceptor : IRequestedInterceptor
{
    event MouseInputDelegate? MouseInput;
    Point GetPosition();
    void SetPosition(int x, int y);
    void Click(int x, int y, MouseButton button);
    void Scroll(int scrollAmount);
}