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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeWarningMachinesResponse : AcsResponse
	{

		private int? currentPage;

		private int? pageSize;

		private string requestId;

		private int? totalCount;

		private int? count;

		private List<DescribeWarningMachines_WarningMachine> warningMachines;

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
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

		public List<DescribeWarningMachines_WarningMachine> WarningMachines
		{
			get
			{
				return warningMachines;
			}
			set	
			{
				warningMachines = value;
			}
		}

		public class DescribeWarningMachines_WarningMachine
		{

			private int? status;

			private string internetIp;

			private string instanceId;

			private int? highWarningCount;

			private string intranetIp;

			private string regionId;

			private int? lowWarningCount;

			private bool? portOpen;

			private string uuid;

			private int? mediumWarningCount;

			private int? passCount;

			private string instanceName;

			public int? Status
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

			public string InternetIp
			{
				get
				{
					return internetIp;
				}
				set	
				{
					internetIp = value;
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

			public int? HighWarningCount
			{
				get
				{
					return highWarningCount;
				}
				set	
				{
					highWarningCount = value;
				}
			}

			public string IntranetIp
			{
				get
				{
					return intranetIp;
				}
				set	
				{
					intranetIp = value;
				}
			}

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

			public int? LowWarningCount
			{
				get
				{
					return lowWarningCount;
				}
				set	
				{
					lowWarningCount = value;
				}
			}

			public bool? PortOpen
			{
				get
				{
					return portOpen;
				}
				set	
				{
					portOpen = value;
				}
			}

			public string Uuid
			{
				get
				{
					return uuid;
				}
				set	
				{
					uuid = value;
				}
			}

			public int? MediumWarningCount
			{
				get
				{
					return mediumWarningCount;
				}
				set	
				{
					mediumWarningCount = value;
				}
			}

			public int? PassCount
			{
				get
				{
					return passCount;
				}
				set	
				{
					passCount = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}
		}
	}
}
