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
        public static DetectStackResourceDriftResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DetectStackResourceDriftResponse detectStackResourceDriftResponse = new DetectStackResourceDriftResponse();

			detectStackResourceDriftResponse.HttpResponse = _ctx.HttpResponse;
			detectStackResourceDriftResponse.RequestId = _ctx.StringValue("DetectStackResourceDrift.RequestId");
			detectStackResourceDriftResponse.DriftDetectionTime = _ctx.StringValue("DetectStackResourceDrift.DriftDetectionTime");
			detectStackResourceDriftResponse.ResourceDriftStatus = _ctx.StringValue("DetectStackResourceDrift.ResourceDriftStatus");
			detectStackResourceDriftResponse.StackId = _ctx.StringValue("DetectStackResourceDrift.StackId");
			detectStackResourceDriftResponse.ResourceType = _ctx.StringValue("DetectStackResourceDrift.ResourceType");
			detectStackResourceDriftResponse.PhysicalResourceId = _ctx.StringValue("DetectStackResourceDrift.PhysicalResourceId");
			detectStackResourceDriftResponse.LogicalResourceId = _ctx.StringValue("DetectStackResourceDrift.LogicalResourceId");
			detectStackResourceDriftResponse.ActualProperties = _ctx.StringValue("DetectStackResourceDrift.ActualProperties");
			detectStackResourceDriftResponse.ExpectedProperties = _ctx.StringValue("DetectStackResourceDrift.ExpectedProperties");

			List<DetectStackResourceDriftResponse.DetectStackResourceDrift_PropertyDifference> detectStackResourceDriftResponse_propertyDifferences = new List<DetectStackResourceDriftResponse.DetectStackResourceDrift_PropertyDifference>();
			for (int i = 0; i < _ctx.Length("DetectStackResourceDrift.PropertyDifferences.Length"); i++) {
				DetectStackResourceDriftResponse.DetectStackResourceDrift_PropertyDifference propertyDifference = new DetectStackResourceDriftResponse.DetectStackResourceDrift_PropertyDifference();
				propertyDifference.PropertyPath = _ctx.StringValue("DetectStackResourceDrift.PropertyDifferences["+ i +"].PropertyPath");
				propertyDifference.ActualValue = _ctx.StringValue("DetectStackResourceDrift.PropertyDifferences["+ i +"].ActualValue");
				propertyDifference.ExpectedValue = _ctx.StringValue("DetectStackResourceDrift.PropertyDifferences["+ i +"].ExpectedValue");
				propertyDifference.DifferenceType = _ctx.StringValue("DetectStackResourceDrift.PropertyDifferences["+ i +"].DifferenceType");

				detectStackResourceDriftResponse_propertyDifferences.Add(propertyDifference);
			}
			detectStackResourceDriftResponse.PropertyDifferences = detectStackResourceDriftResponse_propertyDifferences;
        
			return detectStackResourceDriftResponse;
        }
    }
}
