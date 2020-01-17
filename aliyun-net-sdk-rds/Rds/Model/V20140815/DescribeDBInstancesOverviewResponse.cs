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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDBInstancesOverviewResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDBInstancesOverview_RegionModel> regions;

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

		public List<DescribeDBInstancesOverview_RegionModel> Regions
		{
			get
			{
				return regions;
			}
			set	
			{
				regions = value;
			}
		}

		public class DescribeDBInstancesOverview_RegionModel
		{

			private string region;

			private string engineCount;

			private int? totalCount;

			private List<DescribeDBInstancesOverview_TypeModel> typeModels;

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public string EngineCount
			{
				get
				{
					return engineCount;
				}
				set	
				{
					engineCount = value;
				}
			}

			public int? TotalCount
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

			public List<DescribeDBInstancesOverview_TypeModel> TypeModels
			{
				get
				{
					return typeModels;
				}
				set	
				{
					typeModels = value;
				}
			}

			public class DescribeDBInstancesOverview_TypeModel
			{

				private string instanceDateType;

				private int? count;

				private List<DescribeDBInstancesOverview_InstanceModel> instanceModels;

				public string InstanceDateType
				{
					get
					{
						return instanceDateType;
					}
					set	
					{
						instanceDateType = value;
					}
				}

				public int? Count
				{
					get
					{
						return count;
					}
					set	
					{
						count = value;
					}
				}

				public List<DescribeDBInstancesOverview_InstanceModel> InstanceModels
				{
					get
					{
						return instanceModels;
					}
					set	
					{
						instanceModels = value;
					}
				}

				public class DescribeDBInstancesOverview_InstanceModel
				{

					private string dBInstanceId;

					private string region;

					private string zoneId;

					private string engine;

					private string payType;

					private string createdTime;

					private string expireTime;

					private string lockMode;

					private string dBInstanceStatus;

					public string DBInstanceId
					{
						get
						{
							return dBInstanceId;
						}
						set	
						{
							dBInstanceId = value;
						}
					}

					public string Region
					{
						get
						{
							return region;
						}
						set	
						{
							region = value;
						}
					}

					public string ZoneId
					{
						get
						{
							return zoneId;
						}
						set	
						{
							zoneId = value;
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

					public string PayType
					{
						get
						{
							return payType;
						}
						set	
						{
							payType = value;
						}
					}

					public string CreatedTime
					{
						get
						{
							return createdTime;
						}
						set	
						{
							createdTime = value;
						}
					}

					public string ExpireTime
					{
						get
						{
							return expireTime;
						}
						set	
						{
							expireTime = value;
						}
					}

					public string LockMode
					{
						get
						{
							return lockMode;
						}
						set	
						{
							lockMode = value;
						}
					}

					public string DBInstanceStatus
					{
						get
						{
							return dBInstanceStatus;
						}
						set	
						{
							dBInstanceStatus = value;
						}
					}
				}
			}
		}
	}
}
