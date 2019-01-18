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

namespace Aliyun.Acs.TeslaMaxCompute.Model.V20180104
{
	public class QueryTopologyResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private List<QueryTopology_ResultItem> result;

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

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

		public List<QueryTopology_ResultItem> Result
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

		public class QueryTopology_ResultItem
		{

			private string lastUpdate;

			private List<QueryTopology_RegionItem> regions;

			public string LastUpdate
			{
				get
				{
					return lastUpdate;
				}
				set	
				{
					lastUpdate = value;
				}
			}

			public List<QueryTopology_RegionItem> Regions
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

			public class QueryTopology_RegionItem
			{

				private string region;

				private string regionEnName;

				private string regionCnName;

				private List<QueryTopology_ClusterItem> clusters;

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

				public string RegionEnName
				{
					get
					{
						return regionEnName;
					}
					set	
					{
						regionEnName = value;
					}
				}

				public string RegionCnName
				{
					get
					{
						return regionCnName;
					}
					set	
					{
						regionCnName = value;
					}
				}

				public List<QueryTopology_ClusterItem> Clusters
				{
					get
					{
						return clusters;
					}
					set	
					{
						clusters = value;
					}
				}

				public class QueryTopology_ClusterItem
				{

					private string cluster;

					private string productLine;

					private string productClass;

					private string netCode;

					private string business;

					private string machineRoom;

					private string netArch;

					public string Cluster
					{
						get
						{
							return cluster;
						}
						set	
						{
							cluster = value;
						}
					}

					public string ProductLine
					{
						get
						{
							return productLine;
						}
						set	
						{
							productLine = value;
						}
					}

					public string ProductClass
					{
						get
						{
							return productClass;
						}
						set	
						{
							productClass = value;
						}
					}

					public string NetCode
					{
						get
						{
							return netCode;
						}
						set	
						{
							netCode = value;
						}
					}

					public string Business
					{
						get
						{
							return business;
						}
						set	
						{
							business = value;
						}
					}

					public string MachineRoom
					{
						get
						{
							return machineRoom;
						}
						set	
						{
							machineRoom = value;
						}
					}

					public string NetArch
					{
						get
						{
							return netArch;
						}
						set	
						{
							netArch = value;
						}
					}
				}
			}
		}
	}
}