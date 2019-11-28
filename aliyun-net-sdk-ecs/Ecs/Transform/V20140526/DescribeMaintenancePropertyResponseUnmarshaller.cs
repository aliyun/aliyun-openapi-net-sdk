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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeMaintenancePropertyResponseUnmarshaller
    {
        public static DescribeMaintenancePropertyResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeMaintenancePropertyResponse describeMaintenancePropertyResponse = new DescribeMaintenancePropertyResponse();

			describeMaintenancePropertyResponse.HttpResponse = context.HttpResponse;
			describeMaintenancePropertyResponse.RequestId = context.StringValue("DescribeMaintenanceProperty.RequestId");
			describeMaintenancePropertyResponse.TotalCount = context.IntegerValue("DescribeMaintenanceProperty.TotalCount");
			describeMaintenancePropertyResponse.PageNumber = context.IntegerValue("DescribeMaintenanceProperty.PageNumber");
			describeMaintenancePropertyResponse.PageSize = context.IntegerValue("DescribeMaintenanceProperty.PageSize");

			List<DescribeMaintenancePropertyResponse.DescribeMaintenanceProperty_MaintenanceProperty> describeMaintenancePropertyResponse_maintenancePropertySet = new List<DescribeMaintenancePropertyResponse.DescribeMaintenanceProperty_MaintenanceProperty>();
			for (int i = 0; i < context.Length("DescribeMaintenanceProperty.MaintenancePropertySet.Length"); i++) {
				DescribeMaintenancePropertyResponse.DescribeMaintenanceProperty_MaintenanceProperty maintenanceProperty = new DescribeMaintenancePropertyResponse.DescribeMaintenanceProperty_MaintenanceProperty();
				maintenanceProperty.InstanceId = context.StringValue("DescribeMaintenanceProperty.MaintenancePropertySet["+ i +"].InstanceId");
				maintenanceProperty.StartTime = context.StringValue("DescribeMaintenanceProperty.MaintenancePropertySet["+ i +"].StartTime");
				maintenanceProperty.EndTime = context.StringValue("DescribeMaintenanceProperty.MaintenancePropertySet["+ i +"].EndTime");
				maintenanceProperty.ActionOnMaintenance = context.StringValue("DescribeMaintenanceProperty.MaintenancePropertySet["+ i +"].ActionOnMaintenance");

				describeMaintenancePropertyResponse_maintenancePropertySet.Add(maintenanceProperty);
			}
			describeMaintenancePropertyResponse.MaintenancePropertySet = describeMaintenancePropertyResponse_maintenancePropertySet;
        
			return describeMaintenancePropertyResponse;
        }
    }
}
