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
using Aliyun.Acs.HBase.Model.V20190101;

namespace Aliyun.Acs.HBase.Transform.V20190101
{
    public class QueryHBaseHaDBResponseUnmarshaller
    {
        public static QueryHBaseHaDBResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryHBaseHaDBResponse queryHBaseHaDBResponse = new QueryHBaseHaDBResponse();

			queryHBaseHaDBResponse.HttpResponse = _ctx.HttpResponse;
			queryHBaseHaDBResponse.RequestId = _ctx.StringValue("QueryHBaseHaDB.RequestId");
			queryHBaseHaDBResponse.TotalCount = _ctx.LongValue("QueryHBaseHaDB.TotalCount");
			queryHBaseHaDBResponse.PageNumber = _ctx.IntegerValue("QueryHBaseHaDB.PageNumber");
			queryHBaseHaDBResponse.PageSize = _ctx.IntegerValue("QueryHBaseHaDB.PageSize");

			List<QueryHBaseHaDBResponse.QueryHBaseHaDB_Cluster> queryHBaseHaDBResponse_clusterList = new List<QueryHBaseHaDBResponse.QueryHBaseHaDB_Cluster>();
			for (int i = 0; i < _ctx.Length("QueryHBaseHaDB.ClusterList.Length"); i++) {
				QueryHBaseHaDBResponse.QueryHBaseHaDB_Cluster cluster = new QueryHBaseHaDBResponse.QueryHBaseHaDB_Cluster();
				cluster.HaName = _ctx.StringValue("QueryHBaseHaDB.ClusterList["+ i +"].HaName");
				cluster.BdsName = _ctx.StringValue("QueryHBaseHaDB.ClusterList["+ i +"].BdsName");
				cluster.ActiveName = _ctx.StringValue("QueryHBaseHaDB.ClusterList["+ i +"].ActiveName");
				cluster.StandbyName = _ctx.StringValue("QueryHBaseHaDB.ClusterList["+ i +"].StandbyName");

				List<QueryHBaseHaDBResponse.QueryHBaseHaDB_Cluster.QueryHBaseHaDB_HaSlbConn> cluster_haSlbConnList = new List<QueryHBaseHaDBResponse.QueryHBaseHaDB_Cluster.QueryHBaseHaDB_HaSlbConn>();
				for (int j = 0; j < _ctx.Length("QueryHBaseHaDB.ClusterList["+ i +"].HaSlbConnList.Length"); j++) {
					QueryHBaseHaDBResponse.QueryHBaseHaDB_Cluster.QueryHBaseHaDB_HaSlbConn haSlbConn = new QueryHBaseHaDBResponse.QueryHBaseHaDB_Cluster.QueryHBaseHaDB_HaSlbConn();
					haSlbConn.SlbType = _ctx.StringValue("QueryHBaseHaDB.ClusterList["+ i +"].HaSlbConnList["+ j +"].SlbType");
					haSlbConn.SlbConnAddr = _ctx.StringValue("QueryHBaseHaDB.ClusterList["+ i +"].HaSlbConnList["+ j +"].SlbConnAddr");
					haSlbConn.HbaseType = _ctx.StringValue("QueryHBaseHaDB.ClusterList["+ i +"].HaSlbConnList["+ j +"].HbaseType");

					cluster_haSlbConnList.Add(haSlbConn);
				}
				cluster.HaSlbConnList = cluster_haSlbConnList;

				queryHBaseHaDBResponse_clusterList.Add(cluster);
			}
			queryHBaseHaDBResponse.ClusterList = queryHBaseHaDBResponse_clusterList;
        
			return queryHBaseHaDBResponse;
        }
    }
}
