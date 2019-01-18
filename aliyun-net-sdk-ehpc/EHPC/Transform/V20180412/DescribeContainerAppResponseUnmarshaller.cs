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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.EHPC.Model.V20180412;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class DescribeContainerAppResponseUnmarshaller
    {
        public static DescribeContainerAppResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeContainerAppResponse describeContainerAppResponse = new DescribeContainerAppResponse();

			describeContainerAppResponse.HttpResponse = context.HttpResponse;
			describeContainerAppResponse.RequestId = context.StringValue("DescribeContainerApp.RequestId");

			DescribeContainerAppResponse.DescribeContainerApp_ContainerAppInfo containerAppInfo = new DescribeContainerAppResponse.DescribeContainerApp_ContainerAppInfo();
			containerAppInfo.Id = context.StringValue("DescribeContainerApp.ContainerAppInfo.Id");
			containerAppInfo.Name = context.StringValue("DescribeContainerApp.ContainerAppInfo.Name");
			containerAppInfo.Description = context.StringValue("DescribeContainerApp.ContainerAppInfo.Description");
			containerAppInfo.Repository = context.StringValue("DescribeContainerApp.ContainerAppInfo.Repository");
			containerAppInfo.ImageTag = context.StringValue("DescribeContainerApp.ContainerAppInfo.ImageTag");
			containerAppInfo.CreateTime = context.StringValue("DescribeContainerApp.ContainerAppInfo.CreateTime");
			containerAppInfo.Type = context.StringValue("DescribeContainerApp.ContainerAppInfo.Type");
			describeContainerAppResponse.ContainerAppInfo = containerAppInfo;
        
			return describeContainerAppResponse;
        }
    }
}