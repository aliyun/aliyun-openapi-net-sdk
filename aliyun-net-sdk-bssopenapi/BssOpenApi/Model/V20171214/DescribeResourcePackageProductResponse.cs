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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class DescribeResourcePackageProductResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private long? orderId;

		private DescribeResourcePackageProduct_Data data;

		[JsonProperty(PropertyName = "Code")]
		public string Code
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

		[JsonProperty(PropertyName = "Message")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "OrderId")]
		public long? OrderId
		{
			get
			{
				return orderId;
			}
			set	
			{
				orderId = value;
			}
		}

		[JsonProperty(PropertyName = "Data")]
		public DescribeResourcePackageProduct_Data Data
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

		public class DescribeResourcePackageProduct_Data
		{

			private List<DescribeResourcePackageProduct_ResourcePackage> resourcePackages;

			[JsonProperty(PropertyName = "ResourcePackages")]
			public List<DescribeResourcePackageProduct_ResourcePackage> ResourcePackages
			{
				get
				{
					return resourcePackages;
				}
				set	
				{
					resourcePackages = value;
				}
			}

			public class DescribeResourcePackageProduct_ResourcePackage
			{

				private string productType;

				private string name;

				private string productCode;

				private List<DescribeResourcePackageProduct_PackageType> packageTypes;

				[JsonProperty(PropertyName = "ProductType")]
				public string ProductType
				{
					get
					{
						return productType;
					}
					set	
					{
						productType = value;
					}
				}

				[JsonProperty(PropertyName = "Name")]
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

				[JsonProperty(PropertyName = "ProductCode")]
				public string ProductCode
				{
					get
					{
						return productCode;
					}
					set	
					{
						productCode = value;
					}
				}

				[JsonProperty(PropertyName = "PackageTypes")]
				public List<DescribeResourcePackageProduct_PackageType> PackageTypes
				{
					get
					{
						return packageTypes;
					}
					set	
					{
						packageTypes = value;
					}
				}

				public class DescribeResourcePackageProduct_PackageType
				{

					private string code;

					private string name;

					private List<DescribeResourcePackageProduct_Property> properties;

					private List<DescribeResourcePackageProduct_Specification> specifications;

					[JsonProperty(PropertyName = "Code")]
					public string Code
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

					[JsonProperty(PropertyName = "Name")]
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

					[JsonProperty(PropertyName = "Properties")]
					public List<DescribeResourcePackageProduct_Property> Properties
					{
						get
						{
							return properties;
						}
						set	
						{
							properties = value;
						}
					}

					[JsonProperty(PropertyName = "Specifications")]
					public List<DescribeResourcePackageProduct_Specification> Specifications
					{
						get
						{
							return specifications;
						}
						set	
						{
							specifications = value;
						}
					}

					public class DescribeResourcePackageProduct_Property
					{

						private string name;

						private string _value;

						[JsonProperty(PropertyName = "Name")]
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

						[JsonProperty(PropertyName = "_Value")]
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

					public class DescribeResourcePackageProduct_Specification
					{

						private string name;

						private string _value;

						private List<DescribeResourcePackageProduct_AvailableDuration> availableDurations;

						[JsonProperty(PropertyName = "Name")]
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

						[JsonProperty(PropertyName = "_Value")]
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

						[JsonProperty(PropertyName = "AvailableDurations")]
						public List<DescribeResourcePackageProduct_AvailableDuration> AvailableDurations
						{
							get
							{
								return availableDurations;
							}
							set	
							{
								availableDurations = value;
							}
						}

						public class DescribeResourcePackageProduct_AvailableDuration
						{

							private int? _value;

							private string name;

							private string unit;

							[JsonProperty(PropertyName = "_Value")]
							public int? _Value
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

							[JsonProperty(PropertyName = "Name")]
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

							[JsonProperty(PropertyName = "Unit")]
							public string Unit
							{
								get
								{
									return unit;
								}
								set	
								{
									unit = value;
								}
							}
						}
					}
				}
			}
		}
	}
}
