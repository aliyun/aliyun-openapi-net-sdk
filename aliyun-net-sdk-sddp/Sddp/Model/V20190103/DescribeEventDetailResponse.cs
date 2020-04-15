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

namespace Aliyun.Acs.Sddp.Model.V20190103
{
	public class DescribeEventDetailResponse : AcsResponse
	{

		private string requestId;

		private DescribeEventDetail__Event _event;

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

		public DescribeEventDetail__Event _Event
		{
			get
			{
				return _event;
			}
			set	
			{
				_event = value;
			}
		}

		public class DescribeEventDetail__Event
		{

			private long? id;

			private long? userId;

			private string loginName;

			private string displayName;

			private string productCode;

			private string typeCode;

			private string typeName;

			private string subTypeCode;

			private string subTypeName;

			private long? alertTime;

			private string dataInstance;

			private long? eventTime;

			private int? status;

			private string statusName;

			private long? dealUserId;

			private string dealLoginName;

			private string dealDisplayName;

			private long? dealTime;

			private string departName;

			private bool? backed;

			private string dealReason;

			private DescribeEventDetail_Detail detail;

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

			public long? UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string LoginName
			{
				get
				{
					return loginName;
				}
				set	
				{
					loginName = value;
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

			public string TypeCode
			{
				get
				{
					return typeCode;
				}
				set	
				{
					typeCode = value;
				}
			}

			public string TypeName
			{
				get
				{
					return typeName;
				}
				set	
				{
					typeName = value;
				}
			}

			public string SubTypeCode
			{
				get
				{
					return subTypeCode;
				}
				set	
				{
					subTypeCode = value;
				}
			}

			public string SubTypeName
			{
				get
				{
					return subTypeName;
				}
				set	
				{
					subTypeName = value;
				}
			}

			public long? AlertTime
			{
				get
				{
					return alertTime;
				}
				set	
				{
					alertTime = value;
				}
			}

			public string DataInstance
			{
				get
				{
					return dataInstance;
				}
				set	
				{
					dataInstance = value;
				}
			}

			public long? EventTime
			{
				get
				{
					return eventTime;
				}
				set	
				{
					eventTime = value;
				}
			}

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

			public string StatusName
			{
				get
				{
					return statusName;
				}
				set	
				{
					statusName = value;
				}
			}

			public long? DealUserId
			{
				get
				{
					return dealUserId;
				}
				set	
				{
					dealUserId = value;
				}
			}

			public string DealLoginName
			{
				get
				{
					return dealLoginName;
				}
				set	
				{
					dealLoginName = value;
				}
			}

			public string DealDisplayName
			{
				get
				{
					return dealDisplayName;
				}
				set	
				{
					dealDisplayName = value;
				}
			}

			public long? DealTime
			{
				get
				{
					return dealTime;
				}
				set	
				{
					dealTime = value;
				}
			}

			public string DepartName
			{
				get
				{
					return departName;
				}
				set	
				{
					departName = value;
				}
			}

			public bool? Backed
			{
				get
				{
					return backed;
				}
				set	
				{
					backed = value;
				}
			}

			public string DealReason
			{
				get
				{
					return dealReason;
				}
				set	
				{
					dealReason = value;
				}
			}

			public DescribeEventDetail_Detail Detail
			{
				get
				{
					return detail;
				}
				set	
				{
					detail = value;
				}
			}

			public class DescribeEventDetail_Detail
			{

				private List<DescribeEventDetail_ContentItem> content;

				private List<DescribeEventDetail_ChartItem> chart;

				private List<DescribeEventDetail_ResourceInfoItem> resourceInfo;

				public List<DescribeEventDetail_ContentItem> Content
				{
					get
					{
						return content;
					}
					set	
					{
						content = value;
					}
				}

				public List<DescribeEventDetail_ChartItem> Chart
				{
					get
					{
						return chart;
					}
					set	
					{
						chart = value;
					}
				}

				public List<DescribeEventDetail_ResourceInfoItem> ResourceInfo
				{
					get
					{
						return resourceInfo;
					}
					set	
					{
						resourceInfo = value;
					}
				}

				public class DescribeEventDetail_ContentItem
				{

					private string label;

					private string _value;

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

				public class DescribeEventDetail_ChartItem
				{

					private string label;

					private string xLabel;

					private string yLabel;

					private string type;

					private DescribeEventDetail_Data data;

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

					public string XLabel
					{
						get
						{
							return xLabel;
						}
						set	
						{
							xLabel = value;
						}
					}

					public string YLabel
					{
						get
						{
							return yLabel;
						}
						set	
						{
							yLabel = value;
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

					public DescribeEventDetail_Data Data
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

					public class DescribeEventDetail_Data
					{

						private string x;

						private string y;

						public string X
						{
							get
							{
								return x;
							}
							set	
							{
								x = value;
							}
						}

						public string Y
						{
							get
							{
								return y;
							}
							set	
							{
								y = value;
							}
						}
					}
				}

				public class DescribeEventDetail_ResourceInfoItem
				{

					private string label;

					private string _value;

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
