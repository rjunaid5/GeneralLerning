/*REST is an architecture 
REST API uses design principles of REST
it only works for HTTP(x)
it is stateless
It supports Content negotiation
*/

/*
WCF can also implement RESTAPI but can also implement SOAP or other
WebAPI is only for REST API
*/

/*
Stateful-
Stateless-

*/

/*
In order to avoid too many persons to hit on the URL we put lock on the Service, so that only one client executes the result
        public TService Service
        {
            get
            {
                if (this._service == null)
                    lock (this._mutexInitServiceLock)
                    {
                        if (this._service == null) this._service = new TService();
                    }

                return this._service;
            }
        }
*/

/*
Content Negotiation
Content Negotiation happens when client specifies media type or what kind of data it wants
it is done in the request Accept Header

*/

/*
Return Types of WebAPI
- Https Result
- ActionResult<T>

*/