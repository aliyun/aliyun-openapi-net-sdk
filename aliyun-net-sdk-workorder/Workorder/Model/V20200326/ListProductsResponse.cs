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

namespace Aliyun.Acs.Workorder.Model.V20200326
{
	public class ListProductsResponse : AcsResponse
	{

		private int? code;

		private bool? success;

		private string message;

		private string requestId;

		private ListProducts_Data data;

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

		public ListProducts_Data Data
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

		public class ListProducts_Data
		{

			private List<ListProducts_TechMoreItem> techMore;

			private List<ListProducts_HotConsultationItem> hotConsultation;

			private List<ListProducts_ConsultationMoreItem> consultationMore;

			private List<ListProducts_HotTechItem> hotTech;

			public List<ListProducts_TechMoreItem> TechMore
			{
				get
				{
					return techMore;
				}
				set	
				{
					techMore = value;
				}
			}

			public List<ListProducts_HotConsultationItem> HotConsultation
			{
				get
				{
					return hotConsultation;
				}
				set	
				{
					hotConsultation = value;
				}
			}

			public List<ListProducts_ConsultationMoreItem> ConsultationMore
			{
				get
				{
					return consultationMore;
				}
				set	
				{
					consultationMore = value;
				}
			}

			public List<ListProducts_HotTechItem> HotTech
			{
				get
				{
					return hotTech;
				}
				set	
				{
					hotTech = value;
				}
			}

			public class ListProducts_TechMoreItem
			{

				private string groupName;

				private List<ListProducts_ProductListItem> productList;

				public string GroupName
				{
					get
					{
						return groupName;
					}
					set	
					{
						groupName = value;
					}
				}

				public List<ListProducts_ProductListItem> ProductList
				{
					get
					{
						return productList;
					}
					set	
					{
						productList = value;
					}
				}

				public class ListProducts_ProductListItem
				{

					private string name;

					private string productCode;

					private string description;

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
				}
			}

			public class ListProducts_HotConsultationItem
			{

				private string name;

				private string productCode;

				private string description;

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
			}

			public class ListProducts_ConsultationMoreItem
			{

				private string name;

				private string productCode;

				private string description;

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
			}

			public class ListProducts_HotTechItem
			{

				private string name;

				private string productCode;

				private string description;

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
			}
		}
	}
}
