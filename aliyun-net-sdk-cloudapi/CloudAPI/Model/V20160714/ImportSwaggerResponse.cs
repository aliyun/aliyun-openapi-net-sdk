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

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
	public class ImportSwaggerResponse : AcsResponse
	{

		private string requestId;

		private List<ImportSwagger_ApiImportSwaggerSuccess> success;

		private List<ImportSwagger_ApiImportSwaggerFailed> failed;

		private List<ImportSwagger_ApiImportModelFailed> modelFailed;

		private List<ImportSwagger_ApiImportModelSuccess> modelSuccess;

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

		public List<ImportSwagger_ApiImportSwaggerSuccess> Success
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

		public List<ImportSwagger_ApiImportSwaggerFailed> Failed
		{
			get
			{
				return failed;
			}
			set	
			{
				failed = value;
			}
		}

		public List<ImportSwagger_ApiImportModelFailed> ModelFailed
		{
			get
			{
				return modelFailed;
			}
			set	
			{
				modelFailed = value;
			}
		}

		public List<ImportSwagger_ApiImportModelSuccess> ModelSuccess
		{
			get
			{
				return modelSuccess;
			}
			set	
			{
				modelSuccess = value;
			}
		}

		public class ImportSwagger_ApiImportSwaggerSuccess
		{

			private string path;

			private string httpMethod;

			private string apiUid;

			private string apiOperation;

			public string Path
			{
				get
				{
					return path;
				}
				set	
				{
					path = value;
				}
			}

			public string HttpMethod
			{
				get
				{
					return httpMethod;
				}
				set	
				{
					httpMethod = value;
				}
			}

			public string ApiUid
			{
				get
				{
					return apiUid;
				}
				set	
				{
					apiUid = value;
				}
			}

			public string ApiOperation
			{
				get
				{
					return apiOperation;
				}
				set	
				{
					apiOperation = value;
				}
			}
		}

		public class ImportSwagger_ApiImportSwaggerFailed
		{

			private string path;

			private string httpMethod;

			private string errorMsg;

			public string Path
			{
				get
				{
					return path;
				}
				set	
				{
					path = value;
				}
			}

			public string HttpMethod
			{
				get
				{
					return httpMethod;
				}
				set	
				{
					httpMethod = value;
				}
			}

			public string ErrorMsg
			{
				get
				{
					return errorMsg;
				}
				set	
				{
					errorMsg = value;
				}
			}
		}

		public class ImportSwagger_ApiImportModelFailed
		{

			private string groupId;

			private string modelName;

			private string errorMsg;

			public string GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public string ModelName
			{
				get
				{
					return modelName;
				}
				set	
				{
					modelName = value;
				}
			}

			public string ErrorMsg
			{
				get
				{
					return errorMsg;
				}
				set	
				{
					errorMsg = value;
				}
			}
		}

		public class ImportSwagger_ApiImportModelSuccess
		{

			private string modelUid;

			private string modelOperation;

			private string groupId;

			private string modelName;

			public string ModelUid
			{
				get
				{
					return modelUid;
				}
				set	
				{
					modelUid = value;
				}
			}

			public string ModelOperation
			{
				get
				{
					return modelOperation;
				}
				set	
				{
					modelOperation = value;
				}
			}

			public string GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public string ModelName
			{
				get
				{
					return modelName;
				}
				set	
				{
					modelName = value;
				}
			}
		}
	}
}
