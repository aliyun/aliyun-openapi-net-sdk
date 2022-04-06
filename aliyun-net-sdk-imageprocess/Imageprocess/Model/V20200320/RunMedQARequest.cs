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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.imageprocess.Transform;
using Aliyun.Acs.imageprocess.Transform.V20200320;

namespace Aliyun.Acs.imageprocess.Model.V20200320
{
    public class RunMedQARequest : RpcAcsRequest<RunMedQAResponse>
    {
        public RunMedQARequest()
            : base("imageprocess", "2020-03-20", "RunMedQA", "imageprocess", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.imageprocess.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.imageprocess.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string sessionId;

		private string orgName;

		private List<string> answerImageDataLists = new List<string>(){ };

		private List<string> answerTextLists = new List<string>(){ };

		private string department;

		private List<string> answerImageURLLists = new List<string>(){ };

		private string questionType;

		private string orgId;

		public string SessionId
		{
			get
			{
				return sessionId;
			}
			set	
			{
				sessionId = value;
				DictionaryUtil.Add(BodyParameters, "SessionId", value);
			}
		}

		public string OrgName
		{
			get
			{
				return orgName;
			}
			set	
			{
				orgName = value;
				DictionaryUtil.Add(BodyParameters, "OrgName", value);
			}
		}

		public List<string> AnswerImageDataLists
		{
			get
			{
				return answerImageDataLists;
			}

			set
			{
				answerImageDataLists = value;
				if(answerImageDataLists != null)
				{
					for (int depth1 = 0; depth1 < answerImageDataLists.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"AnswerImageDataList." + (depth1 + 1), answerImageDataLists[depth1]);
					}
				}
			}
		}

		public List<string> AnswerTextLists
		{
			get
			{
				return answerTextLists;
			}

			set
			{
				answerTextLists = value;
				if(answerTextLists != null)
				{
					for (int depth1 = 0; depth1 < answerTextLists.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"AnswerTextList." + (depth1 + 1), answerTextLists[depth1]);
					}
				}
			}
		}

		public string Department
		{
			get
			{
				return department;
			}
			set	
			{
				department = value;
				DictionaryUtil.Add(BodyParameters, "Department", value);
			}
		}

		public List<string> AnswerImageURLLists
		{
			get
			{
				return answerImageURLLists;
			}

			set
			{
				answerImageURLLists = value;
				if(answerImageURLLists != null)
				{
					for (int depth1 = 0; depth1 < answerImageURLLists.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"AnswerImageURLList." + (depth1 + 1), answerImageURLLists[depth1]);
					}
				}
			}
		}

		public string QuestionType
		{
			get
			{
				return questionType;
			}
			set	
			{
				questionType = value;
				DictionaryUtil.Add(BodyParameters, "QuestionType", value);
			}
		}

		public string OrgId
		{
			get
			{
				return orgId;
			}
			set	
			{
				orgId = value;
				DictionaryUtil.Add(BodyParameters, "OrgId", value);
			}
		}

		public class AnswerImageDataList
		{

			private string answerImageData;

			public string AnswerImageData
			{
				get
				{
					return answerImageData;
				}
				set	
				{
					answerImageData = value;
				}
			}
		}

		public class AnswerTextList
		{

			private string answerText;

			public string AnswerText
			{
				get
				{
					return answerText;
				}
				set	
				{
					answerText = value;
				}
			}
		}

		public class AnswerImageURLList
		{

			private string answerImageURL;

			public string AnswerImageURL
			{
				get
				{
					return answerImageURL;
				}
				set	
				{
					answerImageURL = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RunMedQAResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RunMedQAResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
