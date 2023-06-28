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

namespace Aliyun.Acs.alimt.Model.V20181012
{
	public class GetTranslateImageBatchResultResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private GetTranslateImageBatchResult_Data data;

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

		public GetTranslateImageBatchResult_Data Data
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

		public class GetTranslateImageBatchResult_Data
		{

			private string status;

			private List<GetTranslateImageBatchResult_CertificateImageTranslateResult> result;

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

			public List<GetTranslateImageBatchResult_CertificateImageTranslateResult> Result
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

			public class GetTranslateImageBatchResult_CertificateImageTranslateResult
			{

				private string inPaintingUrl;

				private string finalImageUrl;

				private string templateJson;

				private string sourceImageUrl;

				private int? code;

				private string message;

				private bool? success;

				public string InPaintingUrl
				{
					get
					{
						return inPaintingUrl;
					}
					set	
					{
						inPaintingUrl = value;
					}
				}

				public string FinalImageUrl
				{
					get
					{
						return finalImageUrl;
					}
					set	
					{
						finalImageUrl = value;
					}
				}

				public string TemplateJson
				{
					get
					{
						return templateJson;
					}
					set	
					{
						templateJson = value;
					}
				}

				public string SourceImageUrl
				{
					get
					{
						return sourceImageUrl;
					}
					set	
					{
						sourceImageUrl = value;
					}
				}

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
			}
		}
	}
}
