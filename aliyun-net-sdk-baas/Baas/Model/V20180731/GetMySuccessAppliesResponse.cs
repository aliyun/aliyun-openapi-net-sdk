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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Model.V20180731
{
	public class GetMySuccessAppliesResponse : AcsResponse
	{

		private string requestId;

		private List<GetMySuccessApplies_ResultItem> result;

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

		public List<GetMySuccessApplies_ResultItem> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class GetMySuccessApplies_ResultItem
		{

			private string bizid;

			private int? nodeNumber;

			private int? blockHeight;

			private int? transactionSum;

			private long? createTime;

			private int? abnormalNodes;

			private string version;

			private bool? isRole;

			private bool? normal;

			private string name;

			private List<GetMySuccessApplies_NodeInfoListItem> nodeInfoList;

			public string Bizid
			{
				get
				{
					return bizid;
				}
				set	
				{
					bizid = value;
				}
			}

			public int? NodeNumber
			{
				get
				{
					return nodeNumber;
				}
				set	
				{
					nodeNumber = value;
				}
			}

			public int? BlockHeight
			{
				get
				{
					return blockHeight;
				}
				set	
				{
					blockHeight = value;
				}
			}

			public int? TransactionSum
			{
				get
				{
					return transactionSum;
				}
				set	
				{
					transactionSum = value;
				}
			}

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public int? AbnormalNodes
			{
				get
				{
					return abnormalNodes;
				}
				set	
				{
					abnormalNodes = value;
				}
			}

			public string Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
				}
			}

			public bool? IsRole
			{
				get
				{
					return isRole;
				}
				set	
				{
					isRole = value;
				}
			}

			public bool? Normal
			{
				get
				{
					return normal;
				}
				set	
				{
					normal = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public List<GetMySuccessApplies_NodeInfoListItem> NodeInfoList
			{
				get
				{
					return nodeInfoList;
				}
				set	
				{
					nodeInfoList = value;
				}
			}

			public class GetMySuccessApplies_NodeInfoListItem
			{

				private string nodeName;

				private bool? status;

				private string version;

				private long? blockHeight;

				public string NodeName
				{
					get
					{
						return nodeName;
					}
					set	
					{
						nodeName = value;
					}
				}

				public bool? Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}

				public string Version
				{
					get
					{
						return version;
					}
					set	
					{
						version = value;
					}
				}

				public long? BlockHeight
				{
					get
					{
						return blockHeight;
					}
					set	
					{
						blockHeight = value;
					}
				}
			}
		}
	}
}