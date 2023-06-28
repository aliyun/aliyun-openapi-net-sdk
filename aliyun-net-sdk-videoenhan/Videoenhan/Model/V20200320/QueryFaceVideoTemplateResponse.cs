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

namespace Aliyun.Acs.videoenhan.Model.V20200320
{
	public class QueryFaceVideoTemplateResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private QueryFaceVideoTemplate_Data data;

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

		public QueryFaceVideoTemplate_Data Data
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

		public class QueryFaceVideoTemplate_Data
		{

			private List<QueryFaceVideoTemplate_ElementsItem> elements;

			public List<QueryFaceVideoTemplate_ElementsItem> Elements
			{
				get
				{
					return elements;
				}
				set	
				{
					elements = value;
				}
			}

			public class QueryFaceVideoTemplate_ElementsItem
			{

				private string createTime;

				private string updateTime;

				private string userId;

				private string templateId;

				private string templateURL;

				private List<QueryFaceVideoTemplate_FaceInfosItem> faceInfos;

				public string CreateTime
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

				public string UpdateTime
				{
					get
					{
						return updateTime;
					}
					set	
					{
						updateTime = value;
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

				public string TemplateId
				{
					get
					{
						return templateId;
					}
					set	
					{
						templateId = value;
					}
				}

				public string TemplateURL
				{
					get
					{
						return templateURL;
					}
					set	
					{
						templateURL = value;
					}
				}

				public List<QueryFaceVideoTemplate_FaceInfosItem> FaceInfos
				{
					get
					{
						return faceInfos;
					}
					set	
					{
						faceInfos = value;
					}
				}

				public class QueryFaceVideoTemplate_FaceInfosItem
				{

					private string templateFaceID;

					private string templateFaceURL;

					public string TemplateFaceID
					{
						get
						{
							return templateFaceID;
						}
						set	
						{
							templateFaceID = value;
						}
					}

					public string TemplateFaceURL
					{
						get
						{
							return templateFaceURL;
						}
						set	
						{
							templateFaceURL = value;
						}
					}
				}
			}
		}
	}
}
