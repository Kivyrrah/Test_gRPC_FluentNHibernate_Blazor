// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/product.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ProductGRPC.Shared.Protos {
  /// <summary>
  /// Định nghĩa service Product
  /// </summary>
  public static partial class ProductService
  {
    static readonly string __ServiceName = "product.ProductService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductGRPC.Shared.Protos.GetProductRequest> __Marshaller_product_GetProductRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductGRPC.Shared.Protos.GetProductRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductGRPC.Shared.Protos.ProductModel> __Marshaller_product_ProductModel = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductGRPC.Shared.Protos.ProductModel.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductGRPC.Shared.Protos.GetAllProductsRequest> __Marshaller_product_GetAllProductsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductGRPC.Shared.Protos.GetAllProductsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductGRPC.Shared.Protos.ProductListResponse> __Marshaller_product_ProductListResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductGRPC.Shared.Protos.ProductListResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductGRPC.Shared.Protos.CreateProductRequest> __Marshaller_product_CreateProductRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductGRPC.Shared.Protos.CreateProductRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductGRPC.Shared.Protos.UpdateProductRequest> __Marshaller_product_UpdateProductRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductGRPC.Shared.Protos.UpdateProductRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductGRPC.Shared.Protos.DeleteProductRequest> __Marshaller_product_DeleteProductRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductGRPC.Shared.Protos.DeleteProductRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProductGRPC.Shared.Protos.DeleteProductResponse> __Marshaller_product_DeleteProductResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProductGRPC.Shared.Protos.DeleteProductResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ProductGRPC.Shared.Protos.GetProductRequest, global::ProductGRPC.Shared.Protos.ProductModel> __Method_GetProductById = new grpc::Method<global::ProductGRPC.Shared.Protos.GetProductRequest, global::ProductGRPC.Shared.Protos.ProductModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetProductById",
        __Marshaller_product_GetProductRequest,
        __Marshaller_product_ProductModel);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ProductGRPC.Shared.Protos.GetAllProductsRequest, global::ProductGRPC.Shared.Protos.ProductListResponse> __Method_GetAllProducts = new grpc::Method<global::ProductGRPC.Shared.Protos.GetAllProductsRequest, global::ProductGRPC.Shared.Protos.ProductListResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllProducts",
        __Marshaller_product_GetAllProductsRequest,
        __Marshaller_product_ProductListResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ProductGRPC.Shared.Protos.CreateProductRequest, global::ProductGRPC.Shared.Protos.ProductModel> __Method_CreateProduct = new grpc::Method<global::ProductGRPC.Shared.Protos.CreateProductRequest, global::ProductGRPC.Shared.Protos.ProductModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateProduct",
        __Marshaller_product_CreateProductRequest,
        __Marshaller_product_ProductModel);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ProductGRPC.Shared.Protos.UpdateProductRequest, global::ProductGRPC.Shared.Protos.ProductModel> __Method_UpdateProduct = new grpc::Method<global::ProductGRPC.Shared.Protos.UpdateProductRequest, global::ProductGRPC.Shared.Protos.ProductModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateProduct",
        __Marshaller_product_UpdateProductRequest,
        __Marshaller_product_ProductModel);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ProductGRPC.Shared.Protos.DeleteProductRequest, global::ProductGRPC.Shared.Protos.DeleteProductResponse> __Method_DeleteProduct = new grpc::Method<global::ProductGRPC.Shared.Protos.DeleteProductRequest, global::ProductGRPC.Shared.Protos.DeleteProductResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteProduct",
        __Marshaller_product_DeleteProductRequest,
        __Marshaller_product_DeleteProductResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ProductGRPC.Shared.Protos.ProductReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ProductService</summary>
    [grpc::BindServiceMethod(typeof(ProductService), "BindService")]
    public abstract partial class ProductServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ProductGRPC.Shared.Protos.ProductModel> GetProductById(global::ProductGRPC.Shared.Protos.GetProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ProductGRPC.Shared.Protos.ProductListResponse> GetAllProducts(global::ProductGRPC.Shared.Protos.GetAllProductsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ProductGRPC.Shared.Protos.ProductModel> CreateProduct(global::ProductGRPC.Shared.Protos.CreateProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ProductGRPC.Shared.Protos.ProductModel> UpdateProduct(global::ProductGRPC.Shared.Protos.UpdateProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ProductGRPC.Shared.Protos.DeleteProductResponse> DeleteProduct(global::ProductGRPC.Shared.Protos.DeleteProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ProductService</summary>
    public partial class ProductServiceClient : grpc::ClientBase<ProductServiceClient>
    {
      /// <summary>Creates a new client for ProductService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ProductServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ProductService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ProductServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ProductServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ProductServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ProductGRPC.Shared.Protos.ProductModel GetProductById(global::ProductGRPC.Shared.Protos.GetProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProductById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ProductGRPC.Shared.Protos.ProductModel GetProductById(global::ProductGRPC.Shared.Protos.GetProductRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetProductById, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ProductGRPC.Shared.Protos.ProductModel> GetProductByIdAsync(global::ProductGRPC.Shared.Protos.GetProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProductByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ProductGRPC.Shared.Protos.ProductModel> GetProductByIdAsync(global::ProductGRPC.Shared.Protos.GetProductRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetProductById, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ProductGRPC.Shared.Protos.ProductListResponse GetAllProducts(global::ProductGRPC.Shared.Protos.GetAllProductsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllProducts(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ProductGRPC.Shared.Protos.ProductListResponse GetAllProducts(global::ProductGRPC.Shared.Protos.GetAllProductsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAllProducts, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ProductGRPC.Shared.Protos.ProductListResponse> GetAllProductsAsync(global::ProductGRPC.Shared.Protos.GetAllProductsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllProductsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ProductGRPC.Shared.Protos.ProductListResponse> GetAllProductsAsync(global::ProductGRPC.Shared.Protos.GetAllProductsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAllProducts, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ProductGRPC.Shared.Protos.ProductModel CreateProduct(global::ProductGRPC.Shared.Protos.CreateProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateProduct(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ProductGRPC.Shared.Protos.ProductModel CreateProduct(global::ProductGRPC.Shared.Protos.CreateProductRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateProduct, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ProductGRPC.Shared.Protos.ProductModel> CreateProductAsync(global::ProductGRPC.Shared.Protos.CreateProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateProductAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ProductGRPC.Shared.Protos.ProductModel> CreateProductAsync(global::ProductGRPC.Shared.Protos.CreateProductRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateProduct, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ProductGRPC.Shared.Protos.ProductModel UpdateProduct(global::ProductGRPC.Shared.Protos.UpdateProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateProduct(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ProductGRPC.Shared.Protos.ProductModel UpdateProduct(global::ProductGRPC.Shared.Protos.UpdateProductRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateProduct, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ProductGRPC.Shared.Protos.ProductModel> UpdateProductAsync(global::ProductGRPC.Shared.Protos.UpdateProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateProductAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ProductGRPC.Shared.Protos.ProductModel> UpdateProductAsync(global::ProductGRPC.Shared.Protos.UpdateProductRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateProduct, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ProductGRPC.Shared.Protos.DeleteProductResponse DeleteProduct(global::ProductGRPC.Shared.Protos.DeleteProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteProduct(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ProductGRPC.Shared.Protos.DeleteProductResponse DeleteProduct(global::ProductGRPC.Shared.Protos.DeleteProductRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteProduct, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ProductGRPC.Shared.Protos.DeleteProductResponse> DeleteProductAsync(global::ProductGRPC.Shared.Protos.DeleteProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteProductAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ProductGRPC.Shared.Protos.DeleteProductResponse> DeleteProductAsync(global::ProductGRPC.Shared.Protos.DeleteProductRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteProduct, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ProductServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ProductServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ProductServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetProductById, serviceImpl.GetProductById)
          .AddMethod(__Method_GetAllProducts, serviceImpl.GetAllProducts)
          .AddMethod(__Method_CreateProduct, serviceImpl.CreateProduct)
          .AddMethod(__Method_UpdateProduct, serviceImpl.UpdateProduct)
          .AddMethod(__Method_DeleteProduct, serviceImpl.DeleteProduct).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ProductServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetProductById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProductGRPC.Shared.Protos.GetProductRequest, global::ProductGRPC.Shared.Protos.ProductModel>(serviceImpl.GetProductById));
      serviceBinder.AddMethod(__Method_GetAllProducts, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProductGRPC.Shared.Protos.GetAllProductsRequest, global::ProductGRPC.Shared.Protos.ProductListResponse>(serviceImpl.GetAllProducts));
      serviceBinder.AddMethod(__Method_CreateProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProductGRPC.Shared.Protos.CreateProductRequest, global::ProductGRPC.Shared.Protos.ProductModel>(serviceImpl.CreateProduct));
      serviceBinder.AddMethod(__Method_UpdateProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProductGRPC.Shared.Protos.UpdateProductRequest, global::ProductGRPC.Shared.Protos.ProductModel>(serviceImpl.UpdateProduct));
      serviceBinder.AddMethod(__Method_DeleteProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProductGRPC.Shared.Protos.DeleteProductRequest, global::ProductGRPC.Shared.Protos.DeleteProductResponse>(serviceImpl.DeleteProduct));
    }

  }
}
#endregion
