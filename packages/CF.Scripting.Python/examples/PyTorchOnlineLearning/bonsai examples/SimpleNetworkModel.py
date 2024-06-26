import pandas as pd
import matplotlib.pyplot as plt
import numpy as np
import math

import torch
import torch.nn as nn
import torch.optim as optim


# Define the model
class SimpleModel(nn.Module):
     
    total_loss = 0

    def __init__(self):
        super(SimpleModel, self).__init__()
        self.linear = nn.Linear(1, 1, bias=False)  # One input and one output
        
    def set_loss_and_optimizer(self, criterion, optimizer):      
        print('xxx')
        self.criterion = criterion
        print('yyy')
        self.optimizer = optimizer
        print('zzz')
        
    def forward(self, x):
        self.outputs = self.linear(x)
       
    
    def backward(self, y):
         self.loss = self.criterion(self.outputs, y)
         self.total_loss += self.loss.item()       
         self.optimizer.zero_grad()
         self.loss.backward()
         self.optimizer.step()

    def forward_net(self, input_str):
        values = input_str.split()
        x = torch.tensor([float(num) for num in values])
        #print(x)
        self.forward(x)
        output_string = ' '.join([str(num.item()) for num in self.outputs])
        print(output_string)
        return output_string

    def backward_net(self, target_str):
        values = target_str.split()
        y = torch.tensor([float(num) for num in values])
        self.backward(y)



# Create model
model = SimpleModel()

# Define the loss function and optimizer
criterion = nn.MSELoss()
optimizer = optim.SGD(model.parameters(), lr=0.05)

# Create model
model.set_loss_and_optimizer(criterion, optimizer)





