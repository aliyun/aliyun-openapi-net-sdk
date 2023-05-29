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

namespace Aliyun.Acs.Market.Model.V20151101
{
	public class DescribeProductResponse : AcsResponse
	{

		private long? frontCategoryId;

		private string status;

		private string type;

		private string picUrl;

		private float? score;

		private long? useCount;

		private long? gmtModified;

		private long? supplierPk;

		private long? gmtCreated;

		private string requestId;

		private string shortDescription;

		private string description;

		private string code;

		private string auditFailMsg;

		private string name;

		private long? auditTime;

		private string auditStatus;

		private List<DescribeProduct_ProductSku> productSkus;

		private List<DescribeProduct_ProductExtra> productExtras;

		private DescribeProduct_ShopInfo shopInfo;

		[JsonProperty(PropertyName = "FrontCategoryId")]
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

		[JsonProperty(PropertyName = "Status")]
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

		[JsonProperty(PropertyName = "Type")]
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

		[JsonProperty(PropertyName = "PicUrl")]
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

		[JsonProperty(PropertyName = "Score")]
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

		[JsonProperty(PropertyName = "UseCount")]
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

		[JsonProperty(PropertyName = "GmtModified")]
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

		[JsonProperty(PropertyName = "SupplierPk")]
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

		[JsonProperty(PropertyName = "GmtCreated")]
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

		[JsonProperty(PropertyName = "ShortDescription")]
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

		[JsonProperty(PropertyName = "Description")]
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

		[JsonProperty(PropertyName = "AuditFailMsg")]
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

		[JsonProperty(PropertyName = "AuditTime")]
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

		[JsonProperty(PropertyName = "AuditStatus")]
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

		[JsonProperty(PropertyName = "ProductSkus")]
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

		[JsonProperty(PropertyName = "ProductExtras")]
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

		[JsonProperty(PropertyName = "ShopInfo")]
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

			private bool? hidden;

			private string code;

			private string constraints;

			private string name;

			private string chargeType;

			private List<DescribeProduct_OrderPeriod> orderPeriods;

			private List<DescribeProduct_Module> modules;

			[JsonProperty(PropertyName = "Hidden")]
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

			[JsonProperty(PropertyName = "Constraints")]
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

			[JsonProperty(PropertyName = "ChargeType")]
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

			[JsonProperty(PropertyName = "OrderPeriods")]
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

			[JsonProperty(PropertyName = "Modules")]
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

				[JsonProperty(PropertyName = "PeriodType")]
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

				private string code;

				private string name;

				private string id;

				private List<DescribeProduct_Property> properties;

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

				[JsonProperty(PropertyName = "Id")]
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

				[JsonProperty(PropertyName = "Properties")]
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

					private string key;

					private string showType;

					private string name;

					private string displayUnit;

					private List<DescribeProduct_PropertyValue> propertyValues;

					[JsonProperty(PropertyName = "Key")]
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

					[JsonProperty(PropertyName = "ShowType")]
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

					[JsonProperty(PropertyName = "DisplayUnit")]
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

					[JsonProperty(PropertyName = "PropertyValues")]
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

						private string displayName;

						private string type;

						private string step;

						private string _value;

						private string max;

						private string remark;

						private string min;

						[JsonProperty(PropertyName = "DisplayName")]
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

						[JsonProperty(PropertyName = "Type")]
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

						[JsonProperty(PropertyName = "Step")]
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

						[JsonProperty(PropertyName = "Max")]
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

						[JsonProperty(PropertyName = "Remark")]
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

						[JsonProperty(PropertyName = "Min")]
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
					}
				}
			}
		}

		public class DescribeProduct_ProductExtra
		{

			private string type;

			private string key;

			private string label;

			private int? order;

			private string values;

			[JsonProperty(PropertyName = "Type")]
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

			[JsonProperty(PropertyName = "Key")]
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

			[JsonProperty(PropertyName = "Label")]
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

			[JsonProperty(PropertyName = "Order")]
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

			[JsonProperty(PropertyName = "Values")]
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
		}

		public class DescribeProduct_ShopInfo
		{

			private string name;

			private string emails;

			private long? id;

			private List<DescribeProduct_WangWang> wangWangs;

			private List<string> telephones;

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

			[JsonProperty(PropertyName = "Emails")]
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

			[JsonProperty(PropertyName = "Id")]
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

			[JsonProperty(PropertyName = "WangWangs")]
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

			[JsonProperty(PropertyName = "Telephones")]
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

				private string remark;

				private string userName;

				[JsonProperty(PropertyName = "Remark")]
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

				[JsonProperty(PropertyName = "UserName")]
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
			}
		}
	}
}
