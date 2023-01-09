# Serializable Interface - Generation Addon

<p align="center">
	<img alt="GitHub package.json version" src ="https://img.shields.io/github/package-json/v/Thundernerd/Unity3D-SerializableInterface.Generation" />
	<a href="https://github.com/Thundernerd/Unity3D-SerializableInterface.Generation/issues">
		<img alt="GitHub issues" src ="https://img.shields.io/github/issues/Thundernerd/Unity3D-SerializableInterface.Generation" />
	</a>
	<a href="https://github.com/Thundernerd/Unity3D-SerializableInterface.Generation.Generation/pulls">
		<img alt="GitHub pull requests" src ="https://img.shields.io/github/issues-pr/Thundernerd/Unity3D-SerializableInterface.Generation" />
	</a>
	<a href="https://github.com/Thundernerd/Unity3D-SerializableInterface.Generation/blob/master/LICENSE.md">
		<img alt="GitHub license" src ="https://img.shields.io/github/license/Thundernerd/Unity3D-SerializableInterface.Generation" />
	</a>
	<img alt="GitHub last commit" src ="https://img.shields.io/github/last-commit/Thundernerd/Unity3D-SerializableInterface.Generation" />
</p>

An automatic generation addon to [Serializable Interface](https://github.com/Thundernerd/Unity3D-SerializableInterface)

## Installation
1. The package is available on the [openupm registry](https://openupm.com). You can install it via [openupm-cli](https://github.com/openupm/openupm-cli).
```
openupm add net.tnrd.serializableinterface.generation
```

2. Installing through a [Unity Package](http://package-installer.glitch.me/v1/installer/package.openupm.com/net.tnrd.serializableinterface.generation?registry=https://package.openupm.com) created by the [Package Installer Creator](https://package-installer.glitch.me) from [Needle](https://needle.tools)

[<img src="https://img.shields.io/badge/-Download-success?style=for-the-badge"/>](http://package-installer.glitch.me/v1/installer/package.openupm.com/net.tnrd.serializableinterface.generation?registry=https://package.openupm.com)

## Usage

Usage is pretty easy and straightforward. Assuming you have the following interface
```c#
public interface IMyInterface
{
    void Greet();
}
```

In order to get a SerializableInterface version of this interface automatically generated, simply add the `[SerializableInterface]` attribute on top like so

```c#
[SerializableInterface] // <---
public interface IMyInterface
{
    void Greet();
}
```

This will automatically be picked up by the generator and will create a serializable version for you.

## Contributions
Pull requests are welcomed. Please feel free to fix any issues you find, or add new features.

