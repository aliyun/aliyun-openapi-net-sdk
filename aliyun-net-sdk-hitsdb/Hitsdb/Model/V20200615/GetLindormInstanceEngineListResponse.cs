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

namespace Aliyun.Acs.hitsdb.Model.V20200615
{
	public class GetLindormInstanceEngineListResponse : AcsResponse
	{

		private string requestId;

		private string instanceId;

		private List<GetLindormInstanceEngineList_EngineInfo> engineList;

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

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
			}
		}

		public List<GetLindormInstanceEngineList_EngineInfo> EngineList
		{
			get
			{
				return engineList;
			}
			set	
			{
				engineList = value;
			}
		}

		public class GetLindormInstanceEngineList_EngineInfo
		{

			private string engineType;

			private List<GetLindormInstanceEngineList_NetInfo> netInfoList;

			public string EngineType
			{
				get
				{
					return engineType;
				}
				set	
				{
					engineType = value;
				}
			}

			public List<GetLindormInstanceEngineList_NetInfo> NetInfoList
			{
				get
				{
					return netInfoList;
				}
				set	
				{
					netInfoList = value;
				}
			}

			public class GetLindormInstanceEngineList_NetInfo
			{

				private string netType;

				private string connectionString;

				private int? port;

				private int? accessType;

				public string NetType
				{
					get
					{
						return netType;
					}
					set	
					{
						netType = value;
					}
				}

				public string ConnectionString
				{
					get
					{
						return connectionString;
					}
					set	
					{
						connectionString = value;
					}
				}

				public int? Port
				{
					get
					{
						return port;
					}
					set	
					{
						port = value;
					}
				}

				public int? AccessType
				{
					get
					{
						return accessType;
					}
					set	
					{
						accessType = value;
					}
				}
			}
		}
	}
}
