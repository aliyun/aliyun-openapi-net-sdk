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

namespace Aliyun.Acs.CSB.Model.V20171118
{
	public class DescribeRegionsResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private DescribeRegions_Data data;

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

		public DescribeRegions_Data Data
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

		public class DescribeRegions_Data
		{

			private List<DescribeRegions_Region> regionList;

			public List<DescribeRegions_Region> RegionList
			{
				get
				{
					return regionList;
				}
				set	
				{
					regionList = value;
				}
			}

			public class DescribeRegions_Region
			{

				private string regionId;

				private string regionName;

				private string regionUrl;

				private bool? isdefault;

				private List<DescribeRegions_PhysicalLocation> physicalLocations;

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

				public string RegionName
				{
					get
					{
						return regionName;
					}
					set	
					{
						regionName = value;
					}
				}

				public string RegionUrl
				{
					get
					{
						return regionUrl;
					}
					set	
					{
						regionUrl = value;
					}
				}

				public bool? Isdefault
				{
					get
					{
						return isdefault;
					}
					set	
					{
						isdefault = value;
					}
				}

				public List<DescribeRegions_PhysicalLocation> PhysicalLocations
				{
					get
					{
						return physicalLocations;
					}
					set	
					{
						physicalLocations = value;
					}
				}

				public class DescribeRegions_PhysicalLocation
				{

					private string no;

					private string serviceCode;

					private string type;

					private string name;

					private string status;

					private List<DescribeRegions_Attribute> attributes;

					public string No
					{
						get
						{
							return no;
						}
						set	
						{
							no = value;
						}
					}

					public string ServiceCode
					{
						get
						{
							return serviceCode;
						}
						set	
						{
							serviceCode = value;
						}
					}

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

					public string Status
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

					public List<DescribeRegions_Attribute> Attributes
					{
						get
						{
							return attributes;
						}
						set	
						{
							attributes = value;
						}
					}

					public class DescribeRegions_Attribute
					{

						private string name;

						private string _value;

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
					}
				}
			}
		}
	}
}
