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

namespace Aliyun.Acs.Market.Model.V20151101
{
	public class DescribeProductResponse : AcsResponse
	{

		private string code;

		private string name;

		private string type;

		private string picUrl;

		private string description;

		private string shortDescription;

		private long? useCount;

		private float? score;

		private string status;

		private string auditStatus;

		private string auditFailMsg;

		private long? auditTime;

		private long? gmtCreated;

		private long? gmtModified;

		private string requestId;

		private long? supplierPk;

		private long? frontCategoryId;

		private List<DescribeProduct_ProductSku> productSkus;

		private List<DescribeProduct_ProductExtra> productExtras;

		private DescribeProduct_ShopInfo shopInfo;

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

		public string PicUrl
		{
			get
			{
				return picUrl;
			}
			set	
			{
				picUrl = value;
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
			}
		}

		public string ShortDescription
		{
			get
			{
				return shortDescription;
			}
			set	
			{
				shortDescription = value;
			}
		}

		public long? UseCount
		{
			get
			{
				return useCount;
			}
			set	
			{
				useCount = value;
			}
		}

		public float? Score
		{
			get
			{
				return score;
			}
			set	
			{
				score = value;
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

		public string AuditStatus
		{
			get
			{
				return auditStatus;
			}
			set	
			{
				auditStatus = value;
			}
		}

		public string AuditFailMsg
		{
			get
			{
				return auditFailMsg;
			}
			set	
			{
				auditFailMsg = value;
			}
		}

		public long? AuditTime
		{
			get
			{
				return auditTime;
			}
			set	
			{
				auditTime = value;
			}
		}

		public long? GmtCreated
		{
			get
			{
				return gmtCreated;
			}
			set	
			{
				gmtCreated = value;
			}
		}

		public long? GmtModified
		{
			get
			{
				return gmtModified;
			}
			set	
			{
				gmtModified = value;
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

		public long? SupplierPk
		{
			get
			{
				return supplierPk;
			}
			set	
			{
				supplierPk = value;
			}
		}

		public long? FrontCategoryId
		{
			get
			{
				return frontCategoryId;
			}
			set	
			{
				frontCategoryId = value;
			}
		}

		public List<DescribeProduct_ProductSku> ProductSkus
		{
			get
			{
				return productSkus;
			}
			set	
			{
				productSkus = value;
			}
		}

		public List<DescribeProduct_ProductExtra> ProductExtras
		{
			get
			{
				return productExtras;
			}
			set	
			{
				productExtras = value;
			}
		}

		public DescribeProduct_ShopInfo ShopInfo
		{
			get
			{
				return shopInfo;
			}
			set	
			{
				shopInfo = value;
			}
		}

		public class DescribeProduct_ProductSku
		{

			private string name;

			private string code;

			private string chargeType;

			private string constraints;

			private bool? hidden;

			private List<DescribeProduct_OrderPeriod> orderPeriods;

			private List<DescribeProduct_Module> modules;

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

			public string ChargeType
			{
				get
				{
					return chargeType;
				}
				set	
				{
					chargeType = value;
				}
			}

			public string Constraints
			{
				get
				{
					return constraints;
				}
				set	
				{
					constraints = value;
				}
			}

			public bool? Hidden
			{
				get
				{
					return hidden;
				}
				set	
				{
					hidden = value;
				}
			}

			public List<DescribeProduct_OrderPeriod> OrderPeriods
			{
				get
				{
					return orderPeriods;
				}
				set	
				{
					orderPeriods = value;
				}
			}

			public List<DescribeProduct_Module> Modules
			{
				get
				{
					return modules;
				}
				set	
				{
					modules = value;
				}
			}

			public class DescribeProduct_OrderPeriod
			{

				private string name;

				private string periodType;

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

				public string PeriodType
				{
					get
					{
						return periodType;
					}
					set	
					{
						periodType = value;
					}
				}
			}

			public class DescribeProduct_Module
			{

				private string id;

				private string name;

				private string code;

				private List<DescribeProduct_Property> properties;

				public string Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
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

				public List<DescribeProduct_Property> Properties
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

				public class DescribeProduct_Property
				{

					private string name;

					private string key;

					private string showType;

					private string displayUnit;

					private List<DescribeProduct_PropertyValue> propertyValues;

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

					public string Key
					{
						get
						{
							return key;
						}
						set	
						{
							key = value;
						}
					}

					public string ShowType
					{
						get
						{
							return showType;
						}
						set	
						{
							showType = value;
						}
					}

					public string DisplayUnit
					{
						get
						{
							return displayUnit;
						}
						set	
						{
							displayUnit = value;
						}
					}

					public List<DescribeProduct_PropertyValue> PropertyValues
					{
						get
						{
							return propertyValues;
						}
						set	
						{
							propertyValues = value;
						}
					}

					public class DescribeProduct_PropertyValue
					{

						private string _value;

						private string displayName;

						private string type;

						private string min;

						private string max;

						private string step;

						private string remark;

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

						public string DisplayName
						{
							get
							{
								return displayName;
							}
							set	
							{
								displayName = value;
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

						public string Min
						{
							get
							{
								return min;
							}
							set	
							{
								min = value;
							}
						}

						public string Max
						{
							get
							{
								return max;
							}
							set	
							{
								max = value;
							}
						}

						public string Step
						{
							get
							{
								return step;
							}
							set	
							{
								step = value;
							}
						}

						public string Remark
						{
							get
							{
								return remark;
							}
							set	
							{
								remark = value;
							}
						}
					}
				}
			}
		}

		public class DescribeProduct_ProductExtra
		{

			private string key;

			private string values;

			private string label;

			private int? order;

			private string type;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string Values
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

			public string Label
			{
				get
				{
					return label;
				}
				set	
				{
					label = value;
				}
			}

			public int? Order
			{
				get
				{
					return order;
				}
				set	
				{
					order = value;
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
		}

		public class DescribeProduct_ShopInfo
		{

			private long? id;

			private string name;

			private string emails;

			private List<DescribeProduct_WangWang> wangWangs;

			private List<string> telephones;

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
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

			public string Emails
			{
				get
				{
					return emails;
				}
				set	
				{
					emails = value;
				}
			}

			public List<DescribeProduct_WangWang> WangWangs
			{
				get
				{
					return wangWangs;
				}
				set	
				{
					wangWangs = value;
				}
			}

			public List<string> Telephones
			{
				get
				{
					return telephones;
				}
				set	
				{
					telephones = value;
				}
			}

			public class DescribeProduct_WangWang
			{

				private string userName;

				private string remark;

				public string UserName
				{
					get
					{
						return userName;
					}
					set	
					{
						userName = value;
					}
				}

				public string Remark
				{
					get
					{
						return remark;
					}
					set	
					{
						remark = value;
					}
				}
			}
		}
	}
}
