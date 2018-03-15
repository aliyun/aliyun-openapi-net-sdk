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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeLogicDBInstanceTopologyResponse : AcsResponse
	{

		private int? dBInstanceId;

		private string dBInstanceName;

		private int? dBInstanceStatus;

		private string dBInstanceStatusDesc;

		private string dBInstanceConnType;

		private string dBInstanceDescription;

		private string engine;

		private string engineVersion;

		private List<DescribeLogicDBInstanceTopology_LogicDBInstanceParameter> items;

		public int? DBInstanceId
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

		public string DBInstanceName
		{
			get
			{
				return dBInstanceName;
			}
			set	
			{
				dBInstanceName = value;
			}
		}

		public int? DBInstanceStatus
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

		public string DBInstanceStatusDesc
		{
			get
			{
				return dBInstanceStatusDesc;
			}
			set	
			{
				dBInstanceStatusDesc = value;
			}
		}

		public string DBInstanceConnType
		{
			get
			{
				return dBInstanceConnType;
			}
			set	
			{
				dBInstanceConnType = value;
			}
		}

		public string DBInstanceDescription
		{
			get
			{
				return dBInstanceDescription;
			}
			set	
			{
				dBInstanceDescription = value;
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

		public string EngineVersion
		{
			get
			{
				return engineVersion;
			}
			set	
			{
				engineVersion = value;
			}
		}

		public List<DescribeLogicDBInstanceTopology_LogicDBInstanceParameter> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeLogicDBInstanceTopology_LogicDBInstanceParameter
		{

			private int? dBInstanceID;

			private string dBInstanceName;

			private int? dBInstanceStatus;

			private string dBInstanceStatusDesc;

			private string dBInstanceConnType;

			private string dBInstanceDescription;

			private string engine;

			private string engineVersion;

			private string characterType;

			public int? DBInstanceID
			{
				get
				{
					return dBInstanceID;
				}
				set	
				{
					dBInstanceID = value;
				}
			}

			public string DBInstanceName
			{
				get
				{
					return dBInstanceName;
				}
				set	
				{
					dBInstanceName = value;
				}
			}

			public int? DBInstanceStatus
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

			public string DBInstanceStatusDesc
			{
				get
				{
					return dBInstanceStatusDesc;
				}
				set	
				{
					dBInstanceStatusDesc = value;
				}
			}

			public string DBInstanceConnType
			{
				get
				{
					return dBInstanceConnType;
				}
				set	
				{
					dBInstanceConnType = value;
				}
			}

			public string DBInstanceDescription
			{
				get
				{
					return dBInstanceDescription;
				}
				set	
				{
					dBInstanceDescription = value;
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

			public string EngineVersion
			{
				get
				{
					return engineVersion;
				}
				set	
				{
					engineVersion = value;
				}
			}

			public string CharacterType
			{
				get
				{
					return characterType;
				}
				set	
				{
					characterType = value;
				}
			}
		}
	}
}