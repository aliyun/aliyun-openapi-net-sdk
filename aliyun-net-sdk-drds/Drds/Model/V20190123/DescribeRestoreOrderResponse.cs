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

namespace Aliyun.Acs.Drds.Model.V20190123
{
	public class DescribeRestoreOrderResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private DescribeRestoreOrder_RestoreOrderDO restoreOrderDO;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public DescribeRestoreOrder_RestoreOrderDO RestoreOrderDO
		{
			get
			{
				return restoreOrderDO;
			}
			set	
			{
				restoreOrderDO = value;
			}
		}

		public class DescribeRestoreOrder_RestoreOrderDO
		{

			private List<DescribeRestoreOrder_DrdsOrderDOListItem> drdsOrderDOList;

			private List<DescribeRestoreOrder_RdsOrderDOListItem> rdsOrderDOList;

			private List<DescribeRestoreOrder_PolarOrderDOListItem> polarOrderDOList;

			public List<DescribeRestoreOrder_DrdsOrderDOListItem> DrdsOrderDOList
			{
				get
				{
					return drdsOrderDOList;
				}
				set	
				{
					drdsOrderDOList = value;
				}
			}

			public List<DescribeRestoreOrder_RdsOrderDOListItem> RdsOrderDOList
			{
				get
				{
					return rdsOrderDOList;
				}
				set	
				{
					rdsOrderDOList = value;
				}
			}

			public List<DescribeRestoreOrder_PolarOrderDOListItem> PolarOrderDOList
			{
				get
				{
					return polarOrderDOList;
				}
				set	
				{
					polarOrderDOList = value;
				}
			}

			public class DescribeRestoreOrder_DrdsOrderDOListItem
			{

				private string regionId;

				private string azoneId;

				private string network;

				private string vpcId;

				private string vSwtichId;

				private string instSpec;

				public string RegionId
				{
					get
					{
						return regionId;
					}
					set	
					{
						regionId = value;
					}
				}

				public string AzoneId
				{
					get
					{
						return azoneId;
					}
					set	
					{
						azoneId = value;
					}
				}

				public string Network
				{
					get
					{
						return network;
					}
					set	
					{
						network = value;
					}
				}

				public string VpcId
				{
					get
					{
						return vpcId;
					}
					set	
					{
						vpcId = value;
					}
				}

				public string VSwtichId
				{
					get
					{
						return vSwtichId;
					}
					set	
					{
						vSwtichId = value;
					}
				}

				public string InstSpec
				{
					get
					{
						return instSpec;
					}
					set	
					{
						instSpec = value;
					}
				}
			}

			public class DescribeRestoreOrder_RdsOrderDOListItem
			{

				private string regionId;

				private string azoneId;

				private string engine;

				private string version;

				private string instanceClass;

				private string dbInstanceStorage;

				private string network;

				private long? num;

				public string RegionId
				{
					get
					{
						return regionId;
					}
					set	
					{
						regionId = value;
					}
				}

				public string AzoneId
				{
					get
					{
						return azoneId;
					}
					set	
					{
						azoneId = value;
					}
				}

				public string Engine
				{
					get
					{
						return engine;
					}
					set	
					{
						engine = value;
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

				public string InstanceClass
				{
					get
					{
						return instanceClass;
					}
					set	
					{
						instanceClass = value;
					}
				}

				public string DbInstanceStorage
				{
					get
					{
						return dbInstanceStorage;
					}
					set	
					{
						dbInstanceStorage = value;
					}
				}

				public string Network
				{
					get
					{
						return network;
					}
					set	
					{
						network = value;
					}
				}

				public long? Num
				{
					get
					{
						return num;
					}
					set	
					{
						num = value;
					}
				}
			}

			public class DescribeRestoreOrder_PolarOrderDOListItem
			{

				private string regionId;

				private string azoneId;

				private string engine;

				private string version;

				private string instanceClass;

				private string dbInstanceStorage;

				private string network;

				private long? num;

				public string RegionId
				{
					get
					{
						return regionId;
					}
					set	
					{
						regionId = value;
					}
				}

				public string AzoneId
				{
					get
					{
						return azoneId;
					}
					set	
					{
						azoneId = value;
					}
				}

				public string Engine
				{
					get
					{
						return engine;
					}
					set	
					{
						engine = value;
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

				public string InstanceClass
				{
					get
					{
						return instanceClass;
					}
					set	
					{
						instanceClass = value;
					}
				}

				public string DbInstanceStorage
				{
					get
					{
						return dbInstanceStorage;
					}
					set	
					{
						dbInstanceStorage = value;
					}
				}

				public string Network
				{
					get
					{
						return network;
					}
					set	
					{
						network = value;
					}
				}

				public long? Num
				{
					get
					{
						return num;
					}
					set	
					{
						num = value;
					}
				}
			}
		}
	}
}
