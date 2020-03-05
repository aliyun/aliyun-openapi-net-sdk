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

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class GetDataAPIServiceDetailResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private GetDataAPIServiceDetail_Data data;

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public GetDataAPIServiceDetail_Data Data
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

		public class GetDataAPIServiceDetail_Data
		{

			private string apiSrn;

			private int? status;

			private string displayName;

			private string apiPath;

			private long? createTime;

			private long? lastUpdateTime;

			private string dateFormat;

			private string requestMethod;

			private string requestProtocol;

			private string description;

			private GetDataAPIServiceDetail_SqlTemplateDTO sqlTemplateDTO;

			public string ApiSrn
			{
				get
				{
					return apiSrn;
				}
				set	
				{
					apiSrn = value;
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

			public string ApiPath
			{
				get
				{
					return apiPath;
				}
				set	
				{
					apiPath = value;
				}
			}

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public long? LastUpdateTime
			{
				get
				{
					return lastUpdateTime;
				}
				set	
				{
					lastUpdateTime = value;
				}
			}

			public string DateFormat
			{
				get
				{
					return dateFormat;
				}
				set	
				{
					dateFormat = value;
				}
			}

			public string RequestMethod
			{
				get
				{
					return requestMethod;
				}
				set	
				{
					requestMethod = value;
				}
			}

			public string RequestProtocol
			{
				get
				{
					return requestProtocol;
				}
				set	
				{
					requestProtocol = value;
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

			public GetDataAPIServiceDetail_SqlTemplateDTO SqlTemplateDTO
			{
				get
				{
					return sqlTemplateDTO;
				}
				set	
				{
					sqlTemplateDTO = value;
				}
			}

			public class GetDataAPIServiceDetail_SqlTemplateDTO
			{

				private string originSql;

				private string templateSql;

				private List<GetDataAPIServiceDetail_RequestParamsItem> requestParams;

				private List<GetDataAPIServiceDetail_ResponseParamsItem> responseParams;

				public string OriginSql
				{
					get
					{
						return originSql;
					}
					set	
					{
						originSql = value;
					}
				}

				public string TemplateSql
				{
					get
					{
						return templateSql;
					}
					set	
					{
						templateSql = value;
					}
				}

				public List<GetDataAPIServiceDetail_RequestParamsItem> RequestParams
				{
					get
					{
						return requestParams;
					}
					set	
					{
						requestParams = value;
					}
				}

				public List<GetDataAPIServiceDetail_ResponseParamsItem> ResponseParams
				{
					get
					{
						return responseParams;
					}
					set	
					{
						responseParams = value;
					}
				}

				public class GetDataAPIServiceDetail_RequestParamsItem
				{

					private string name;

					private string type;

					private string desc;

					private string example;

					private bool? required;

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

					public string Example
					{
						get
						{
							return example;
						}
						set	
						{
							example = value;
						}
					}

					public bool? Required
					{
						get
						{
							return required;
						}
						set	
						{
							required = value;
						}
					}
				}

				public class GetDataAPIServiceDetail_ResponseParamsItem
				{

					private string name;

					private string type;

					private string desc;

					private string example;

					private bool? required;

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

					public string Example
					{
						get
						{
							return example;
						}
						set	
						{
							example = value;
						}
					}

					public bool? Required
					{
						get
						{
							return required;
						}
						set	
						{
							required = value;
						}
					}
				}
			}
		}
	}
}
