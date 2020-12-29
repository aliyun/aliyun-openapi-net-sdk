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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class DescribeImageGatewayConfigResponseUnmarshaller
    {
        public static DescribeImageGatewayConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeImageGatewayConfigResponse describeImageGatewayConfigResponse = new DescribeImageGatewayConfigResponse();

			describeImageGatewayConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeImageGatewayConfigResponse.RequestId = _ctx.StringValue("DescribeImageGatewayConfig.RequestId");

			DescribeImageGatewayConfigResponse.DescribeImageGatewayConfig_Imagegw imagegw = new DescribeImageGatewayConfigResponse.DescribeImageGatewayConfig_Imagegw();
			imagegw.DefaultImageLocation = _ctx.StringValue("DescribeImageGatewayConfig.Imagegw.DefaultImageLocation");
			imagegw.PullUpdateTimeout = _ctx.LongValue("DescribeImageGatewayConfig.Imagegw.PullUpdateTimeout");
			imagegw.MongoDBURI = _ctx.StringValue("DescribeImageGatewayConfig.Imagegw.MongoDBURI");
			imagegw.ImageExpirationTimeout = _ctx.StringValue("DescribeImageGatewayConfig.Imagegw.ImageExpirationTimeout");
			imagegw.UpdateDateTime = _ctx.StringValue("DescribeImageGatewayConfig.Imagegw.UpdateDateTime");

			List<DescribeImageGatewayConfigResponse.DescribeImageGatewayConfig_Imagegw.DescribeImageGatewayConfig_LocationInfo> imagegw_locations = new List<DescribeImageGatewayConfigResponse.DescribeImageGatewayConfig_Imagegw.DescribeImageGatewayConfig_LocationInfo>();
			for (int i = 0; i < _ctx.Length("DescribeImageGatewayConfig.Imagegw.Locations.Length"); i++) {
				DescribeImageGatewayConfigResponse.DescribeImageGatewayConfig_Imagegw.DescribeImageGatewayConfig_LocationInfo locationInfo = new DescribeImageGatewayConfigResponse.DescribeImageGatewayConfig_Imagegw.DescribeImageGatewayConfig_LocationInfo();
				locationInfo.Location = _ctx.StringValue("DescribeImageGatewayConfig.Imagegw.Locations["+ i +"].Location");
				locationInfo.RemoteType = _ctx.StringValue("DescribeImageGatewayConfig.Imagegw.Locations["+ i +"].RemoteType");
				locationInfo.Authentication = _ctx.StringValue("DescribeImageGatewayConfig.Imagegw.Locations["+ i +"].Authentication");
				locationInfo.URL = _ctx.StringValue("DescribeImageGatewayConfig.Imagegw.Locations["+ i +"].URL");

				imagegw_locations.Add(locationInfo);
			}
			imagegw.Locations = imagegw_locations;
			describeImageGatewayConfigResponse.Imagegw = imagegw;
        
			return describeImageGatewayConfigResponse;
        }
    }
}
