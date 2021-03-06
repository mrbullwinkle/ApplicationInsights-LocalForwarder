// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: exporter/exporter.proto
// </auto-generated>
// Original file comments:
// Copyright 2018, OpenCensus Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Opencensus.Proto.Exporter {
  public static partial class Export
  {
    static readonly string __ServiceName = "opencensus.proto.exporter.Export";

    static readonly grpc::Marshaller<global::Opencensus.Proto.Exporter.ExportSpanRequest> __Marshaller_ExportSpanRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Opencensus.Proto.Exporter.ExportSpanRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Opencensus.Proto.Exporter.ExportSpanResponse> __Marshaller_ExportSpanResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Opencensus.Proto.Exporter.ExportSpanResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Opencensus.Proto.Exporter.ExportSpanRequest, global::Opencensus.Proto.Exporter.ExportSpanResponse> __Method_ExportSpan = new grpc::Method<global::Opencensus.Proto.Exporter.ExportSpanRequest, global::Opencensus.Proto.Exporter.ExportSpanResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "ExportSpan",
        __Marshaller_ExportSpanRequest,
        __Marshaller_ExportSpanResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Opencensus.Proto.Exporter.ExporterReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Export</summary>
    public abstract partial class ExportBase
    {
      public virtual global::System.Threading.Tasks.Task ExportSpan(grpc::IAsyncStreamReader<global::Opencensus.Proto.Exporter.ExportSpanRequest> requestStream, grpc::IServerStreamWriter<global::Opencensus.Proto.Exporter.ExportSpanResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Export</summary>
    public partial class ExportClient : grpc::ClientBase<ExportClient>
    {
      /// <summary>Creates a new client for Export</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ExportClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Export that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ExportClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ExportClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ExportClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncDuplexStreamingCall<global::Opencensus.Proto.Exporter.ExportSpanRequest, global::Opencensus.Proto.Exporter.ExportSpanResponse> ExportSpan(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ExportSpan(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Opencensus.Proto.Exporter.ExportSpanRequest, global::Opencensus.Proto.Exporter.ExportSpanResponse> ExportSpan(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_ExportSpan, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ExportClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ExportClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ExportBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ExportSpan, serviceImpl.ExportSpan).Build();
    }

  }
}
#endregion
