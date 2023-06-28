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

namespace Aliyun.Acs.Linkvisual.Model.V20180120
{
	public class QueryFaceUserByNameResponse : AcsResponse
	{

		private string code;

		private string requestId;

		private string errorMessage;

		private bool? success;

		private QueryFaceUserByName_Data data;

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

		public QueryFaceUserByName_Data Data
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

		public class QueryFaceUserByName_Data
		{

			private int? pageSize;

			private int? total;

			private int? page;

			private List<QueryFaceUserByName_PageData> list;

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

			public int? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public int? Page
			{
				get
				{
					return page;
				}
				set	
				{
					page = value;
				}
			}

			public List<QueryFaceUserByName_PageData> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class QueryFaceUserByName_PageData
			{

				private string _params;

				private string customUserId;

				private long? createTime;

				private string userId;

				private string name;

				private long? modifyTime;

				private List<QueryFaceUserByName_FacePicListItem> facePicList;

				public string _Params
				{
					get
					{
						return _params;
					}
					set	
					{
						_params = value;
					}
				}

				public string CustomUserId
				{
					get
					{
						return customUserId;
					}
					set	
					{
						customUserId = value;
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

				public string UserId
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

				public long? ModifyTime
				{
					get
					{
						return modifyTime;
					}
					set	
					{
						modifyTime = value;
					}
				}

				public List<QueryFaceUserByName_FacePicListItem> FacePicList
				{
					get
					{
						return facePicList;
					}
					set	
					{
						facePicList = value;
					}
				}

				public class QueryFaceUserByName_FacePicListItem
				{

					private string faceUrl;

					private string faceMd5;

					private List<QueryFaceUserByName_FeatureDTO> featureDTOList;

					public string FaceUrl
					{
						get
						{
							return faceUrl;
						}
						set	
						{
							faceUrl = value;
						}
					}

					public string FaceMd5
					{
						get
						{
							return faceMd5;
						}
						set	
						{
							faceMd5 = value;
						}
					}

					public List<QueryFaceUserByName_FeatureDTO> FeatureDTOList
					{
						get
						{
							return featureDTOList;
						}
						set	
						{
							featureDTOList = value;
						}
					}

					public class QueryFaceUserByName_FeatureDTO
					{

						private string algorithmName;

						private string algorithmVersion;

						private string algorithmProvider;

						private string errorMessage;

						private string errorCode;

						private string faceMd5;

						public string AlgorithmName
						{
							get
							{
								return algorithmName;
							}
							set	
							{
								algorithmName = value;
							}
						}

						public string AlgorithmVersion
						{
							get
							{
								return algorithmVersion;
							}
							set	
							{
								algorithmVersion = value;
							}
						}

						public string AlgorithmProvider
						{
							get
							{
								return algorithmProvider;
							}
							set	
							{
								algorithmProvider = value;
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

						public string ErrorCode
						{
							get
							{
								return errorCode;
							}
							set	
							{
								errorCode = value;
							}
						}

						public string FaceMd5
						{
							get
							{
								return faceMd5;
							}
							set	
							{
								faceMd5 = value;
							}
						}
					}
				}
			}
		}
	}
}
