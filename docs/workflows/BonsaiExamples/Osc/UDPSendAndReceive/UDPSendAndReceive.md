# Udp Server and Client

## Summary
This example demonstrates how to setup an Osc server and an Osc client, and how messages can be sent from one to the other. 

## Workflow

:::workflow
![Example](~/workflows//BonsaiExamples/Osc/UDPSendAndReceive/UDPSendAndReceive.bonsai)
:::

## Details
1. Creates a udp communication channel. In this example, this channel will be listening in port 2323, the messages sent by localhost port 0.
2. Creates a second udp communication channel. In this example, this channel will use port 0, to send messages to localhost port 2323.
3. Generates and sends an Osc message with the x and y position of the mouse whenever the mouse moves. 
4. Emits events whenever a message is received with the x and y coordinates of the mouse.

## Follow-up
In this example the communication is done via the localhost (i.e. it uses the same machine both for sending and receiving messages). However, the code can be run in different machines (as far as the machines are in the same LAN network), where the mouse movements executed in one can be sent to the other. To do this, you only need to change the localhost in UdpReceive and UdpSend by the IP addresses of both each machine.


