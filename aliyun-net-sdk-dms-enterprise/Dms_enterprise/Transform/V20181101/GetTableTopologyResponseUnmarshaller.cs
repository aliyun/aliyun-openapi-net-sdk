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
    public class GetTableTopologyResponseUnmarshaller
    {
        public static GetTableTopologyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTableTopologyResponse getTableTopologyResponse = new GetTableTopologyResponse();

			getTableTopologyResponse.HttpResponse = _ctx.HttpResponse;
			getTableTopologyResponse.RequestId = _ctx.StringValue("GetTableTopology.RequestId");
			getTableTopologyResponse.Success = _ctx.BooleanValue("GetTableTopology.Success");
			getTableTopologyResponse.ErrorMessage = _ctx.StringValue("GetTableTopology.ErrorMessage");
			getTableTopologyResponse.ErrorCode = _ctx.StringValue("GetTableTopology.ErrorCode");

			GetTableTopologyResponse.GetTableTopology_TableTopology tableTopology = new GetTableTopologyResponse.GetTableTopology_TableTopology();
			tableTopology.TableGuid = _ctx.StringValue("GetTableTopology.TableTopology.TableGuid");
			tableTopology.TableName = _ctx.StringValue("GetTableTopology.TableTopology.TableName");
			tableTopology.Logic = _ctx.BooleanValue("GetTableTopology.TableTopology.Logic");

			List<GetTableTopologyResponse.GetTableTopology_TableTopology.GetTableTopology_TableTopologyInfo> tableTopology_tableTopologyInfoList = new List<GetTableTopologyResponse.GetTableTopology_TableTopology.GetTableTopology_TableTopologyInfo>();
			for (int i = 0; i < _ctx.Length("GetTableTopology.TableTopology.TableTopologyInfoList.Length"); i++) {
				GetTableTopologyResponse.GetTableTopology_TableTopology.GetTableTopology_TableTopologyInfo tableTopologyInfo = new GetTableTopologyResponse.GetTableTopology_TableTopology.GetTableTopology_TableTopologyInfo();
				tableTopologyInfo.TableNameList = _ctx.StringValue("GetTableTopology.TableTopology.TableTopologyInfoList["+ i +"].TableNameList");
				tableTopologyInfo.TableNameExpr = _ctx.StringValue("GetTableTopology.TableTopology.TableTopologyInfoList["+ i +"].TableNameExpr");
				tableTopologyInfo.TableCount = _ctx.LongValue("GetTableTopology.TableTopology.TableTopologyInfoList["+ i +"].TableCount");
				tableTopologyInfo.DbId = _ctx.LongValue("GetTableTopology.TableTopology.TableTopologyInfoList["+ i +"].DbId");
				tableTopologyInfo.DbSearchName = _ctx.StringValue("GetTableTopology.TableTopology.TableTopologyInfoList["+ i +"].DbSearchName");
				tableTopologyInfo.InstanceId = _ctx.LongValue("GetTableTopology.TableTopology.TableTopologyInfoList["+ i +"].InstanceId");
				tableTopologyInfo.RegionId = _ctx.StringValue("GetTableTopology.TableTopology.TableTopologyInfoList["+ i +"].RegionId");
				tableTopologyInfo.InstanceResourceId = _ctx.StringValue("GetTableTopology.TableTopology.TableTopologyInfoList["+ i +"].InstanceResourceId");
				tableTopologyInfo.InstanceSource = _ctx.StringValue("GetTableTopology.TableTopology.TableTopologyInfoList["+ i +"].InstanceSource");
				tableTopologyInfo.DbName = _ctx.StringValue("GetTableTopology.TableTopology.TableTopologyInfoList["+ i +"].DbName");
				tableTopologyInfo.DbType = _ctx.StringValue("GetTableTopology.TableTopology.TableTopologyInfoList["+ i +"].DbType");

				tableTopology_tableTopologyInfoList.Add(tableTopologyInfo);
			}
			tableTopology.TableTopologyInfoList = tableTopology_tableTopologyInfoList;
			getTableTopologyResponse.TableTopology = tableTopology;
        
			return getTableTopologyResponse;
        }
    }
}
