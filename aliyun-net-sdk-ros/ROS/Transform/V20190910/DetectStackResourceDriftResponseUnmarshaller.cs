/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.ROS.Model.V20190910;

namespace Aliyun.Acs.ROS.Transform.V20190910
{
    public class DetectStackResourceDriftResponseUnmarshaller
    {
        public static DetectStackResourceDriftResponse Unmarshall(UnmarshallerContext context)
        {
			DetectStackResourceDriftResponse detectStackResourceDriftResponse = new DetectStackResourceDriftResponse();

			detectStackResourceDriftResponse.HttpResponse = context.HttpResponse;
			detectStackResourceDriftResponse.RequestId = context.StringValue("DetectStackResourceDrift.RequestId");
			detectStackResourceDriftResponse.DriftDetectionTime = context.StringValue("DetectStackResourceDrift.DriftDetectionTime");
			detectStackResourceDriftResponse.ResourceDriftStatus = context.StringValue("DetectStackResourceDrift.ResourceDriftStatus");
			detectStackResourceDriftResponse.StackId = context.StringValue("DetectStackResourceDrift.StackId");
			detectStackResourceDriftResponse.ResourceType = context.StringValue("DetectStackResourceDrift.ResourceType");
			detectStackResourceDriftResponse.PhysicalResourceId = context.StringValue("DetectStackResourceDrift.PhysicalResourceId");
			detectStackResourceDriftResponse.LogicalResourceId = context.StringValue("DetectStackResourceDrift.LogicalResourceId");
			detectStackResourceDriftResponse.ActualProperties = context.StringValue("DetectStackResourceDrift.ActualProperties");
			detectStackResourceDriftResponse.ExpectedProperties = context.StringValue("DetectStackResourceDrift.ExpectedProperties");

			List<DetectStackResourceDriftResponse.DetectStackResourceDrift_PropertyDifference> detectStackResourceDriftResponse_propertyDifferences = new List<DetectStackResourceDriftResponse.DetectStackResourceDrift_PropertyDifference>();
			for (int i = 0; i < context.Length("DetectStackResourceDrift.PropertyDifferences.Length"); i++) {
				DetectStackResourceDriftResponse.DetectStackResourceDrift_PropertyDifference propertyDifference = new DetectStackResourceDriftResponse.DetectStackResourceDrift_PropertyDifference();
				propertyDifference.PropertyPath = context.StringValue("DetectStackResourceDrift.PropertyDifferences["+ i +"].PropertyPath");
				propertyDifference.ActualValue = context.StringValue("DetectStackResourceDrift.PropertyDifferences["+ i +"].ActualValue");
				propertyDifference.ExpectedValue = context.StringValue("DetectStackResourceDrift.PropertyDifferences["+ i +"].ExpectedValue");
				propertyDifference.DifferenceType = context.StringValue("DetectStackResourceDrift.PropertyDifferences["+ i +"].DifferenceType");

				detectStackResourceDriftResponse_propertyDifferences.Add(propertyDifference);
			}
			detectStackResourceDriftResponse.PropertyDifferences = detectStackResourceDriftResponse_propertyDifferences;
        
			return detectStackResourceDriftResponse;
        }
    }
}
