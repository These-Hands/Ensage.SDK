// <copyright file="ID3D11Context.cs" company="Ensage">
//    Copyright (c) 2018 Ensage.
// </copyright>

namespace Ensage.SDK.Renderer.DX11
{
    using System;

    using PlaySharp.Toolkit.Helper.Annotations;

    using SharpDX.Direct2D1;

    public interface ID3D11Context : IDisposable
    {
        event EventHandler Draw;

        Factory Direct2D1 { get; }

        SharpDX.DirectWrite.Factory DirectWrite { get; }

        RenderTarget RenderTarget { get; }
    }
}