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

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
	public class QueryDataServiceListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private QueryDataServiceList_Result result;

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

		public QueryDataServiceList_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class QueryDataServiceList_Result
		{

			private int? totalNum;

			private int? pageNum;

			private int? pageSize;

			private int? totalPages;

			private List<QueryDataServiceList_QueryDataServiceModel> data;

			public int? TotalNum
			{
				get
				{
					return totalNum;
				}
				set	
				{
					totalNum = value;
				}
			}

			public int? PageNum
			{
				get
				{
					return pageNum;
				}
				set	
				{
					pageNum = value;
				}
			}

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

			public int? TotalPages
			{
				get
				{
					return totalPages;
				}
				set	
				{
					totalPages = value;
				}
			}

			public List<QueryDataServiceList_QueryDataServiceModel> Data
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

			public class QueryDataServiceList_QueryDataServiceModel
			{

				private string ownerName;

				private string cubeId;

				private string creatorId;

				private string modifierName;

				private string gmtModified;

				private string workspaceId;

				private string name;

				private string sid;

				private string desc;

				private string gmtCreate;

				private string ownerId;

				private string cubeName;

				private string workspaceName;

				private string creatorName;

				private string modifierId;

				private QueryDataServiceList_Content content;

				public string OwnerName
				{
					get
					{
						return ownerName;
					}
					set	
					{
						ownerName = value;
					}
				}

				public string CubeId
				{
					get
					{
						return cubeId;
					}
					set	
					{
						cubeId = value;
					}
				}

				public string CreatorId
				{
					get
					{
						return creatorId;
					}
					set	
					{
						creatorId = value;
					}
				}

				public string ModifierName
				{
					get
					{
						return modifierName;
					}
					set	
					{
						modifierName = value;
					}
				}

				public string GmtModified
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

				public string WorkspaceId
				{
					get
					{
						return workspaceId;
					}
					set	
					{
						workspaceId = value;
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

				public string Sid
				{
					get
					{
						return sid;
					}
					set	
					{
						sid = value;
					}
				}

				public string Desc
				{
					get
					{
						return desc;
					}
					set	
					{
						desc = value;
					}
				}

				public string GmtCreate
				{
					get
					{
						return gmtCreate;
					}
					set	
					{
						gmtCreate = value;
					}
				}

				public string OwnerId
				{
					get
					{
						return ownerId;
					}
					set	
					{
						ownerId = value;
					}
				}

				public string CubeName
				{
					get
					{
						return cubeName;
					}
					set	
					{
						cubeName = value;
					}
				}

				public string WorkspaceName
				{
					get
					{
						return workspaceName;
					}
					set	
					{
						workspaceName = value;
					}
				}

				public string CreatorName
				{
					get
					{
						return creatorName;
					}
					set	
					{
						creatorName = value;
					}
				}

				public string ModifierId
				{
					get
					{
						return modifierId;
					}
					set	
					{
						modifierId = value;
					}
				}

				public QueryDataServiceList_Content Content
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

				public class QueryDataServiceList_Content
				{

					private string cubeId;

					private string cubeName;

					private bool? detail;

					private List<QueryDataServiceList_SelectFieldModel> returnFields;

					private QueryDataServiceList_Filter filter;

					public string CubeId
					{
						get
						{
							return cubeId;
						}
						set	
						{
							cubeId = value;
						}
					}

					public string CubeName
					{
						get
						{
							return cubeName;
						}
						set	
						{
							cubeName = value;
						}
					}

					public bool? Detail
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

					public List<QueryDataServiceList_SelectFieldModel> ReturnFields
					{
						get
						{
							return returnFields;
						}
						set	
						{
							returnFields = value;
						}
					}

					public QueryDataServiceList_Filter Filter
					{
						get
						{
							return filter;
						}
						set	
						{
							filter = value;
						}
					}

					public class QueryDataServiceList_SelectFieldModel
					{

						private string orderby;

						private string desc;

						private string alias;

						private string aggregator;

						private QueryDataServiceList_Field field;

						public string Orderby
						{
							get
							{
								return orderby;
							}
							set	
							{
								orderby = value;
							}
						}

						public string Desc
						{
							get
							{
								return desc;
							}
							set	
							{
								desc = value;
							}
						}

						public string Alias
						{
							get
							{
								return alias;
							}
							set	
							{
								alias = value;
							}
						}

						public string Aggregator
						{
							get
							{
								return aggregator;
							}
							set	
							{
								aggregator = value;
							}
						}

						public QueryDataServiceList_Field Field
						{
							get
							{
								return field;
							}
							set	
							{
								field = value;
							}
						}

						public class QueryDataServiceList_Field
						{

							private string fid;

							private string type;

							private string column;

							private string dataType;

							private string granularity;

							private string caption;

							private string name;

							public string Fid
							{
								get
								{
									return fid;
								}
								set	
								{
									fid = value;
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

							public string Column
							{
								get
								{
									return column;
								}
								set	
								{
									column = value;
								}
							}

							public string DataType
							{
								get
								{
									return dataType;
								}
								set	
								{
									dataType = value;
								}
							}

							public string Granularity
							{
								get
								{
									return granularity;
								}
								set	
								{
									granularity = value;
								}
							}

							public string Caption
							{
								get
								{
									return caption;
								}
								set	
								{
									caption = value;
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
						}
					}

					public class QueryDataServiceList_Filter
					{

						private string type;

						private string logicalOperator;

						private List<Dictionary<string, string>> filters;

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

						public string LogicalOperator
						{
							get
							{
								return logicalOperator;
							}
							set	
							{
								logicalOperator = value;
							}
						}

						public List<Dictionary<string, string>> Filters
						{
							get
							{
								return filters;
							}
							set	
							{
								filters = value;
							}
						}
					}
				}
			}
		}
	}
}
