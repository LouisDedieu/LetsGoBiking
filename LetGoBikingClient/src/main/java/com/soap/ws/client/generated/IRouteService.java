
package com.soap.ws.client.generated;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebResult;
import javax.jws.WebService;
import javax.xml.bind.annotation.XmlSeeAlso;
import javax.xml.ws.RequestWrapper;
import javax.xml.ws.ResponseWrapper;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.3.2
 * Generated source version: 2.2
 * 
 */
@WebService(name = "IRouteService", targetNamespace = "http://tempuri.org/")
@XmlSeeAlso({
    ObjectFactory.class
})
public interface IRouteService {


    /**
     * 
     * @param origin
     * @param destination
     * @return
     *     returns com.soap.ws.client.generated.Itinary
     */
    @WebMethod(operationName = "GetItinerary", action = "http://tempuri.org/IRouteService/GetItinerary")
    @WebResult(name = "GetItineraryResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "GetItinerary", targetNamespace = "http://tempuri.org/", className = "com.soap.ws.client.generated.GetItinerary")
    @ResponseWrapper(localName = "GetItineraryResponse", targetNamespace = "http://tempuri.org/", className = "com.soap.ws.client.generated.GetItineraryResponse")
    public Itinary getItinerary(
        @WebParam(name = "origin", targetNamespace = "http://tempuri.org/")
        String origin,
        @WebParam(name = "destination", targetNamespace = "http://tempuri.org/")
        String destination);

}
