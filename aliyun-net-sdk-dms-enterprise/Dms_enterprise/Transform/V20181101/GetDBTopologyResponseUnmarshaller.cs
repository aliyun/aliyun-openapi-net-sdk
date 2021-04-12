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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class GetDBTopologyResponseUnmarshaller
    {
        public static GetDBTopologyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDBTopologyResponse getDBTopologyResponse = new GetDBTopologyResponse();

			getDBTopologyResponse.HttpResponse = _ctx.HttpResponse;
			getDBTopologyResponse.RequestId = _ctx.StringValue("GetDBTopology.RequestId");
			getDBTopologyResponse.ErrorCode = _ctx.StringValue("GetDBTopology.ErrorCode");
			getDBTopologyResponse.ErrorMessage = _ctx.StringValue("GetDBTopology.ErrorMessage");
			getDBTopologyResponse.Success = _ctx.BooleanValue("GetDBTopology.Success");

			GetDBTopologyResponse.GetDBTopology_DBTopology dBTopology = new GetDBTopologyResponse.GetDBTopology_DBTopology();
			dBTopology.LogicDbId = _ctx.LongValue("GetDBTopology.DBTopology.LogicDbId");
			dBTopology.SearchName = _ctx.StringValue("GetDBTopology.DBTopology.SearchName");
			dBTopology.Alias = _ctx.StringValue("GetDBTopology.DBTopology.Alias");
			dBTopology.LogicDbName = _ctx.StringValue("GetDBTopology.DBTopology.LogicDbName");
			dBTopology.EnvType = _ctx.StringValue("GetDBTopology.DBTopology.EnvType");
			dBTopology.DbType = _ctx.StringValue("GetDBTopology.DBTopology.DbType");

			List<GetDBTopologyResponse.GetDBTopology_DBTopology.GetDBTopology_DBTopologyInfo> dBTopology_dBTopologyInfoList = new List<GetDBTopologyResponse.GetDBTopology_DBTopology.GetDBTopology_DBTopologyInfo>();
			for (int i = 0; i < _ctx.Length("GetDBTopology.DBTopology.DBTopologyInfoList.Length"); i++) {
				GetDBTopologyResponse.GetDBTopology_DBTopology.GetDBTopology_DBTopologyInfo dBTopologyInfo = new GetDBTopologyResponse.GetDBTopology_DBTopology.GetDBTopology_DBTopologyInfo();
				dBTopologyInfo.InstanceSource = _ctx.StringValue("GetDBTopology.DBTopology.DBTopologyInfoList["+ i +"].InstanceSource");
				dBTopologyInfo.InstanceResourceId = _ctx.StringValue("GetDBTopology.DBTopology.DBTopologyInfoList["+ i +"].InstanceResourceId");
				dBTopologyInfo.InstanceId = _ctx.LongValue("GetDBTopology.DBTopology.DBTopologyInfoList["+ i +"].InstanceId");
				dBTopologyInfo.SearchName = _ctx.StringValue("GetDBTopology.DBTopology.DBTopologyInfoList["+ i +"].SearchName");
				dBTopologyInfo.DbId = _ctx.LongValue("GetDBTopology.DBTopology.DBTopologyInfoList["+ i +"].DbId");
				dBTopologyInfo.CatalogName = _ctx.StringValue("GetDBTopology.DBTopology.DBTopologyInfoList["+ i +"].CatalogName");
				dBTopologyInfo.RegionId = _ctx.StringValue("GetDBTopology.DBTopology.DBTopologyInfoList["+ i +"].RegionId");
				dBTopologyInfo.EnvType = _ctx.StringValue("GetDBTopology.DBTopology.DBTopologyInfoList["+ i +"].EnvType");
				dBTopologyInfo.DbType = _ctx.StringValue("GetDBTopology.DBTopology.DBTopologyInfoList["+ i +"].DbType");
				dBTopologyInfo.SchemaName = _ctx.StringValue("GetDBTopology.DBTopology.DBTopologyInfoList["+ i +"].SchemaName");

				dBTopology_dBTopologyInfoList.Add(dBTopologyInfo);
			}
			dBTopology.DBTopologyInfoList = dBTopology_dBTopologyInfoList;
			getDBTopologyResponse.DBTopology = dBTopology;
        
			return getDBTopologyResponse;
        }
    }
}
