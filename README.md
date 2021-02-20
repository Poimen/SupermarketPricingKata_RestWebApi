## Supermarket Kata

This is a implementation of the Supermarket Kata making use of distributed services. This is an exercise in practising distributed computing techniques, use FaaS and APIs.

### Kata Description

We’re going to see how far we can get in implementing a supermarket checkout that calculates the total price of a number of items. In a normal supermarket, things are identified using Stock Keeping Units, or SKUs. In our store, we’ll use individual letters of the alphabet (A, B, C, and so on). Our goods are priced individually.

In addition, some items are multi-priced:
 - Buy n of them, and they’ll cost you y pounds. For example, item ‘A’ might cost 50 pounds individually, but this week we have a special offer: buy three ‘A’s and they’ll cost you 130.
 - The price and offer table:
```
    Item  Price   Offer
    --------------------------
    A     50       3 for 130
    B     30       2 for 45
    C     20
    D     15
```

Our checkout accepts items in any order, so that if we scan a B, an A, and another B, we’ll recognize the two B’s and price them at 45 (for a total price so far of 95).

### API Design

1. Create an API for a supermarket products
 - GET `/products` should return all products with pagination controls
 - GET `/products/{id}` should return product specific details ({ id, name, description, price })
 - POST `/products` should add a new product ({ description, price }) returns product id ({ id })


2. Create an API for managing shopping baskets
 - GET `/baskets` should return all baskets for the current user. User authentication and management is out of scope and can be assumed.
 - POST `/baskets` should add a new basket ({ id, total, products: [{ id, name }] })
 - GET `/baskets/{id}` should return all product items from the basket and the basket total ({ total, products: [{ id }]})
 - POST `/baskets/{id}` should add items from the basket ([{ id }])

2. Create an API for offers
 - GET `/offers` should return all current offers
 - GET `/offers/{id}` should return offer detail ({ description, products:[{ id }] })
 - POST `/offers` should create an offer ({ description, products: [{ id }] })


### Design considerations

Each API segment is broken in to services. The design is broken into functions per segment - for instance:
```
GET `/products` => implemented as a function
GET `/products/{id}` => implemented as a separate function
```

This design is closer to more modern computing serverless implementations.

### Testing

Postman scripts provide a level of integration tests against public APIs. Other services have unit tests associated with the necessary implementation details.

### Getting started

Local development is based on a dockerised environment that deploys a Kubernetes cluster using [kindness](https://kubernetes.io/docs/setup/learning-environment/kind/). The assumption is that a Kubernetes cluster is available. This can be accomplished through [kindness](https://kubernetes.io/docs/setup/learning-environment/kind/), [minikube](https://kubernetes.io/docs/setup/learning-environment/minikube/), or other environment (e.g. cloud). For the purposes of this documentation, a cluster is assumed. Installation of a cluster can be done on the provided links.

In the idea of providing an environment to experiment with FaaS, but not linked to a cloud provider, a local instance of a [Kubeless](https://kubeless.io/) is used to provide a FaaS infrastructure layer. A cloud instance can also be used, but for the purposes of this documentation, [Kubeless](https://kubeless.io/) is assumed.

The installation of both Kubernetes and Kubeless

For a local development environment that does not require a cloud account but still allows serverless functionality, a local instance of a [Kubeless](https://kubeless.io/) is used to provide a FaaS infrastructure layer. This infrastructure runs an internal version of [istio](https://istio.io). This also provides access to monitoring and logs.

Further note,
