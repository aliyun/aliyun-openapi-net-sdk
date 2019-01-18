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
using Aliyun.Acs.Drds.Model.V20171016;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Drds.Transform.V20171016
{
    public class QueryInstanceInfoByConnResponseUnmarshaller
    {
        public static QueryInstanceInfoByConnResponse Unmarshall(UnmarshallerContext context)
        {
			QueryInstanceInfoByConnResponse queryInstanceInfoByConnResponse = new QueryInstanceInfoByConnResponse();

			queryInstanceInfoByConnResponse.HttpResponse = context.HttpResponse;
			queryInstanceInfoByConnResponse.RequestId = context.StringValue("QueryInstanceInfoByConn.RequestId");
			queryInstanceInfoByConnResponse.Success = context.BooleanValue("QueryInstanceInfoByConn.Success");

			QueryInstanceInfoByConnResponse.QueryInstanceInfoByConn_Data data = new QueryInstanceInfoByConnResponse.QueryInstanceInfoByConn_Data();
			data.DrdsInstanceId = context.StringValue("QueryInstanceInfoByConn.Data.DrdsInstanceId");
			data.Type = context.StringValue("QueryInstanceInfoByConn.Data.Type");
			data.RegionId = context.StringValue("QueryInstanceInfoByConn.Data.RegionId");
			data.ZoneId = context.StringValue("QueryInstanceInfoByConn.Data.ZoneId");
			data.Description = context.StringValue("QueryInstanceInfoByConn.Data.Description");
			data.NetworkType = context.StringValue("QueryInstanceInfoByConn.Data.NetworkType");
			data.Status = context.StringValue("QueryInstanceInfoByConn.Data.Status");
			data.CreateTime = context.LongValue("QueryInstanceInfoByConn.Data.CreateTime");
			data.Version = context.LongValue("QueryInstanceInfoByConn.Data.Version");
			data.Specification = context.StringValue("QueryInstanceInfoByConn.Data.Specification");
			data.SpecTypeId = context.StringValue("QueryInstanceInfoByConn.Data.SpecTypeId");
			data.SpecTypeName = context.StringValue("QueryInstanceInfoByConn.Data.SpecTypeName");
			data.VpcCloudInstanceId = context.StringValue("QueryInstanceInfoByConn.Data.VpcCloudInstanceId");

			List<QueryInstanceInfoByConnResponse.QueryInstanceInfoByConn_Data.QueryInstanceInfoByConn_Vip> data_vips = new List<QueryInstanceInfoByConnResponse.QueryInstanceInfoByConn_Data.QueryInstanceInfoByConn_Vip>();
			for (int i = 0; i < context.Length("QueryInstanceInfoByConn.Data.Vips.Length"); i++) {
				QueryInstanceInfoByConnResponse.QueryInstanceInfoByConn_Data.QueryInstanceInfoByConn_Vip vip = new QueryInstanceInfoByConnResponse.QueryInstanceInfoByConn_Data.QueryInstanceInfoByConn_Vip();
				vip.IP = context.StringValue("QueryInstanceInfoByConn.Data.Vips["+ i +"].IP");
				vip.Port = context.StringValue("QueryInstanceInfoByConn.Data.Vips["+ i +"].Port");
				vip.Type = context.StringValue("QueryInstanceInfoByConn.Data.Vips["+ i +"].Type");
				vip.VpcId = context.StringValue("QueryInstanceInfoByConn.Data.Vips["+ i +"].VpcId");
				vip.VswitchId = context.StringValue("QueryInstanceInfoByConn.Data.Vips["+ i +"].VswitchId");

				data_vips.Add(vip);
			}
			data.Vips = data_vips;
			queryInstanceInfoByConnResponse.Data = data;
        
			return queryInstanceInfoByConnResponse;
        }
    }
}