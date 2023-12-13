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

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
	public class DescribeAlertSceneResponse : AcsResponse
	{

		private bool? success;

		private int? code;

		private string message;

		private string requestId;

		private List<DescribeAlertScene_DataItem> data;

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

		public List<DescribeAlertScene_DataItem> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeAlertScene_DataItem
		{

			private string alertType;

			private string alertTypeId;

			private string alertName;

			private string alertNameId;

			private string alertTile;

			private string alertTileId;

			private List<DescribeAlertScene_Target> targets;

			public string AlertType
			{
				get
				{
					return alertType;
				}
				set	
				{
					alertType = value;
				}
			}

			public string AlertTypeId
			{
				get
				{
					return alertTypeId;
				}
				set	
				{
					alertTypeId = value;
				}
			}

			public string AlertName
			{
				get
				{
					return alertName;
				}
				set	
				{
					alertName = value;
				}
			}

			public string AlertNameId
			{
				get
				{
					return alertNameId;
				}
				set	
				{
					alertNameId = value;
				}
			}

			public string AlertTile
			{
				get
				{
					return alertTile;
				}
				set	
				{
					alertTile = value;
				}
			}

			public string AlertTileId
			{
				get
				{
					return alertTileId;
				}
				set	
				{
					alertTileId = value;
				}
			}

			public List<DescribeAlertScene_Target> Targets
			{
				get
				{
					return targets;
				}
				set	
				{
					targets = value;
				}
			}

			public class DescribeAlertScene_Target
			{

				private string type;

				private string name;

				private string _value;

				private List<string> values;

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
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

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}

				public List<string> Values
				{
					get
					{
						return values;
					}
					set	
					{
						values = value;
					}
				}
			}
		}
	}
}
