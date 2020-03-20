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
    public class ListStackResourceDriftsResponseUnmarshaller
    {
        public static ListStackResourceDriftsResponse Unmarshall(UnmarshallerContext context)
        {
			ListStackResourceDriftsResponse listStackResourceDriftsResponse = new ListStackResourceDriftsResponse();

			listStackResourceDriftsResponse.HttpResponse = context.HttpResponse;
			listStackResourceDriftsResponse.RequestId = context.StringValue("ListStackResourceDrifts.RequestId");
			listStackResourceDriftsResponse.NextToken = context.StringValue("ListStackResourceDrifts.NextToken");

			List<ListStackResourceDriftsResponse.ListStackResourceDrifts_ResourceDrift> listStackResourceDriftsResponse_resourceDrifts = new List<ListStackResourceDriftsResponse.ListStackResourceDrifts_ResourceDrift>();
			for (int i = 0; i < context.Length("ListStackResourceDrifts.ResourceDrifts.Length"); i++) {
				ListStackResourceDriftsResponse.ListStackResourceDrifts_ResourceDrift resourceDrift = new ListStackResourceDriftsResponse.ListStackResourceDrifts_ResourceDrift();
				resourceDrift.DriftDetectionTime = context.StringValue("ListStackResourceDrifts.ResourceDrifts["+ i +"].DriftDetectionTime");
				resourceDrift.ResourceDriftStatus = context.StringValue("ListStackResourceDrifts.ResourceDrifts["+ i +"].ResourceDriftStatus");
				resourceDrift.StackId = context.StringValue("ListStackResourceDrifts.ResourceDrifts["+ i +"].StackId");
				resourceDrift.ResourceType = context.StringValue("ListStackResourceDrifts.ResourceDrifts["+ i +"].ResourceType");
				resourceDrift.PhysicalResourceId = context.StringValue("ListStackResourceDrifts.ResourceDrifts["+ i +"].PhysicalResourceId");
				resourceDrift.LogicalResourceId = context.StringValue("ListStackResourceDrifts.ResourceDrifts["+ i +"].LogicalResourceId");
				resourceDrift.ActualProperties = context.StringValue("ListStackResourceDrifts.ResourceDrifts["+ i +"].ActualProperties");
				resourceDrift.ExpectedProperties = context.StringValue("ListStackResourceDrifts.ResourceDrifts["+ i +"].ExpectedProperties");

				List<ListStackResourceDriftsResponse.ListStackResourceDrifts_ResourceDrift.ListStackResourceDrifts_PropertyDifference> resourceDrift_propertyDifferences = new List<ListStackResourceDriftsResponse.ListStackResourceDrifts_ResourceDrift.ListStackResourceDrifts_PropertyDifference>();
				for (int j = 0; j < context.Length("ListStackResourceDrifts.ResourceDrifts["+ i +"].PropertyDifferences.Length"); j++) {
					ListStackResourceDriftsResponse.ListStackResourceDrifts_ResourceDrift.ListStackResourceDrifts_PropertyDifference propertyDifference = new ListStackResourceDriftsResponse.ListStackResourceDrifts_ResourceDrift.ListStackResourceDrifts_PropertyDifference();
					propertyDifference.PropertyPath = context.StringValue("ListStackResourceDrifts.ResourceDrifts["+ i +"].PropertyDifferences["+ j +"].PropertyPath");
					propertyDifference.ActualValue = context.StringValue("ListStackResourceDrifts.ResourceDrifts["+ i +"].PropertyDifferences["+ j +"].ActualValue");
					propertyDifference.ExpectedValue = context.StringValue("ListStackResourceDrifts.ResourceDrifts["+ i +"].PropertyDifferences["+ j +"].ExpectedValue");
					propertyDifference.DifferenceType = context.StringValue("ListStackResourceDrifts.ResourceDrifts["+ i +"].PropertyDifferences["+ j +"].DifferenceType");

					resourceDrift_propertyDifferences.Add(propertyDifference);
				}
				resourceDrift.PropertyDifferences = resourceDrift_propertyDifferences;

				listStackResourceDriftsResponse_resourceDrifts.Add(resourceDrift);
			}
			listStackResourceDriftsResponse.ResourceDrifts = listStackResourceDriftsResponse_resourceDrifts;
        
			return listStackResourceDriftsResponse;
        }
    }
}
