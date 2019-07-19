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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class DescribeResourcePackageProductResponse : AcsResponse
	{

		private string requestId;

		private long? orderId;

		private bool? success;

		private string code;

		private string message;

		private DescribeResourcePackageProduct_Data data;

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

				private string productCode;

				private string productType;

				private string name;

				private List<DescribeResourcePackageProduct_PackageType> packageTypes;

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

					private string name;

					private string code;

					private List<DescribeResourcePackageProduct_Property> properties;

					private List<DescribeResourcePackageProduct_Specification> specifications;

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

					public class DescribeResourcePackageProduct_Specification
					{

						private string name;

						private string _value;

						private List<DescribeResourcePackageProduct_AvailableDuration> availableDurations;

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

							private string name;

							private int? _value;

							private string unit;

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
