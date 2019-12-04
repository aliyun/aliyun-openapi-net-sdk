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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.HBase.Model.V20190101
{
	public class QueryHBaseHaDBResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<QueryHBaseHaDB_Cluster> clusterList;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<QueryHBaseHaDB_Cluster> ClusterList
		{
			get
			{
				return clusterList;
			}
			set	
			{
				clusterList = value;
			}
		}

		public class QueryHBaseHaDB_Cluster
		{

			private string haName;

			private string bdsName;

			private string activeName;

			private string standbyName;

			private List<QueryHBaseHaDB_HaSlbConn> haSlbConnList;

			public string HaName
			{
				get
				{
					return haName;
				}
				set	
				{
					haName = value;
				}
			}

			public string BdsName
			{
				get
				{
					return bdsName;
				}
				set	
				{
					bdsName = value;
				}
			}

			public string ActiveName
			{
				get
				{
					return activeName;
				}
				set	
				{
					activeName = value;
				}
			}

			public string StandbyName
			{
				get
				{
					return standbyName;
				}
				set	
				{
					standbyName = value;
				}
			}

			public List<QueryHBaseHaDB_HaSlbConn> HaSlbConnList
			{
				get
				{
					return haSlbConnList;
				}
				set	
				{
					haSlbConnList = value;
				}
			}

			public class QueryHBaseHaDB_HaSlbConn
			{

				private string slbType;

				private string slbConnAddr;

				private string hbaseType;

				public string SlbType
				{
					get
					{
						return slbType;
					}
					set	
					{
						slbType = value;
					}
				}

				public string SlbConnAddr
				{
					get
					{
						return slbConnAddr;
					}
					set	
					{
						slbConnAddr = value;
					}
				}

				public string HbaseType
				{
					get
					{
						return hbaseType;
					}
					set	
					{
						hbaseType = value;
					}
				}
			}
		}
	}
}
