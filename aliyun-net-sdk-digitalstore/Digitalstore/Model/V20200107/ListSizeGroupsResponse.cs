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

namespace Aliyun.Acs.digitalstore.Model.V20200107
{
	public class ListSizeGroupsResponse : AcsResponse
	{

		private int? pageSize;

		private int? pageNumber;

		private string requestId;

		private bool? success;

		private int? totalCount;

		private List<ListSizeGroups_SizeGroupModel> sizeGroups;

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
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

		public List<ListSizeGroups_SizeGroupModel> SizeGroups
		{
			get
			{
				return sizeGroups;
			}
			set	
			{
				sizeGroups = value;
			}
		}

		public class ListSizeGroups_SizeGroupModel
		{

			private string createDate;

			private string description;

			private string name;

			private int? disable;

			private string code;

			private string updateDate;

			private string sizeGroupId;

			private List<ListSizeGroups_SizeModel> sizes;

			public string CreateDate
			{
				get
				{
					return createDate;
				}
				set	
				{
					createDate = value;
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

			public int? Disable
			{
				get
				{
					return disable;
				}
				set	
				{
					disable = value;
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

			public string UpdateDate
			{
				get
				{
					return updateDate;
				}
				set	
				{
					updateDate = value;
				}
			}

			public string SizeGroupId
			{
				get
				{
					return sizeGroupId;
				}
				set	
				{
					sizeGroupId = value;
				}
			}

			public List<ListSizeGroups_SizeModel> Sizes
			{
				get
				{
					return sizes;
				}
				set	
				{
					sizes = value;
				}
			}

			public class ListSizeGroups_SizeModel
			{

				private string description;

				private string sizeName;

				private string sizeGroupCode;

				private string createDate;

				private string sizeGroupId;

				private string sizeCode;

				private string sizeGroupName;

				private string updateDate;

				private int? disable;

				private string sizeId;

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

				public string SizeName
				{
					get
					{
						return sizeName;
					}
					set	
					{
						sizeName = value;
					}
				}

				public string SizeGroupCode
				{
					get
					{
						return sizeGroupCode;
					}
					set	
					{
						sizeGroupCode = value;
					}
				}

				public string CreateDate
				{
					get
					{
						return createDate;
					}
					set	
					{
						createDate = value;
					}
				}

				public string SizeGroupId
				{
					get
					{
						return sizeGroupId;
					}
					set	
					{
						sizeGroupId = value;
					}
				}

				public string SizeCode
				{
					get
					{
						return sizeCode;
					}
					set	
					{
						sizeCode = value;
					}
				}

				public string SizeGroupName
				{
					get
					{
						return sizeGroupName;
					}
					set	
					{
						sizeGroupName = value;
					}
				}

				public string UpdateDate
				{
					get
					{
						return updateDate;
					}
					set	
					{
						updateDate = value;
					}
				}

				public int? Disable
				{
					get
					{
						return disable;
					}
					set	
					{
						disable = value;
					}
				}

				public string SizeId
				{
					get
					{
						return sizeId;
					}
					set	
					{
						sizeId = value;
					}
				}
			}
		}
	}
}
