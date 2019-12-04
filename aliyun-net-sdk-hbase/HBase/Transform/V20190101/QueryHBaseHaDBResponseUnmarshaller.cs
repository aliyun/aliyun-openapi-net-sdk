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
        public static QueryHBaseHaDBResponse Unmarshall(UnmarshallerContext context)
        {
			QueryHBaseHaDBResponse queryHBaseHaDBResponse = new QueryHBaseHaDBResponse();

			queryHBaseHaDBResponse.HttpResponse = context.HttpResponse;
			queryHBaseHaDBResponse.RequestId = context.StringValue("QueryHBaseHaDB.RequestId");
			queryHBaseHaDBResponse.TotalCount = context.LongValue("QueryHBaseHaDB.TotalCount");
			queryHBaseHaDBResponse.PageNumber = context.IntegerValue("QueryHBaseHaDB.PageNumber");
			queryHBaseHaDBResponse.PageSize = context.IntegerValue("QueryHBaseHaDB.PageSize");

			List<QueryHBaseHaDBResponse.QueryHBaseHaDB_Cluster> queryHBaseHaDBResponse_clusterList = new List<QueryHBaseHaDBResponse.QueryHBaseHaDB_Cluster>();
			for (int i = 0; i < context.Length("QueryHBaseHaDB.ClusterList.Length"); i++) {
				QueryHBaseHaDBResponse.QueryHBaseHaDB_Cluster cluster = new QueryHBaseHaDBResponse.QueryHBaseHaDB_Cluster();
				cluster.HaName = context.StringValue("QueryHBaseHaDB.ClusterList["+ i +"].HaName");
				cluster.BdsName = context.StringValue("QueryHBaseHaDB.ClusterList["+ i +"].BdsName");
				cluster.ActiveName = context.StringValue("QueryHBaseHaDB.ClusterList["+ i +"].ActiveName");
				cluster.StandbyName = context.StringValue("QueryHBaseHaDB.ClusterList["+ i +"].StandbyName");

				List<QueryHBaseHaDBResponse.QueryHBaseHaDB_Cluster.QueryHBaseHaDB_HaSlbConn> cluster_haSlbConnList = new List<QueryHBaseHaDBResponse.QueryHBaseHaDB_Cluster.QueryHBaseHaDB_HaSlbConn>();
				for (int j = 0; j < context.Length("QueryHBaseHaDB.ClusterList["+ i +"].HaSlbConnList.Length"); j++) {
					QueryHBaseHaDBResponse.QueryHBaseHaDB_Cluster.QueryHBaseHaDB_HaSlbConn haSlbConn = new QueryHBaseHaDBResponse.QueryHBaseHaDB_Cluster.QueryHBaseHaDB_HaSlbConn();
					haSlbConn.SlbType = context.StringValue("QueryHBaseHaDB.ClusterList["+ i +"].HaSlbConnList["+ j +"].SlbType");
					haSlbConn.SlbConnAddr = context.StringValue("QueryHBaseHaDB.ClusterList["+ i +"].HaSlbConnList["+ j +"].SlbConnAddr");
					haSlbConn.HbaseType = context.StringValue("QueryHBaseHaDB.ClusterList["+ i +"].HaSlbConnList["+ j +"].HbaseType");

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
