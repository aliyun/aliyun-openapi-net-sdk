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

namespace Aliyun.Acs.sae.Model.V20190506
{
	public class ListSecretsResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private string traceId;

		private string errorCode;

		private string code;

		private bool? success;

		private ListSecrets_Data data;

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

		public string TraceId
		{
			get
			{
				return traceId;
			}
			set	
			{
				traceId = value;
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

		public ListSecrets_Data Data
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

		public class ListSecrets_Data
		{

			private List<ListSecrets_Secret> secrets;

			public List<ListSecrets_Secret> Secrets
			{
				get
				{
					return secrets;
				}
				set	
				{
					secrets = value;
				}
			}

			public class ListSecrets_Secret
			{

				private string namespaceId;

				private long? secretId;

				private string secretName;

				private string secretType;

				private string secretData;

				private long? createTime;

				private long? updateTime;

				private List<ListSecrets_RelateApp> relateApps;

				public string NamespaceId
				{
					get
					{
						return namespaceId;
					}
					set	
					{
						namespaceId = value;
					}
				}

				public long? SecretId
				{
					get
					{
						return secretId;
					}
					set	
					{
						secretId = value;
					}
				}

				public string SecretName
				{
					get
					{
						return secretName;
					}
					set	
					{
						secretName = value;
					}
				}

				public string SecretType
				{
					get
					{
						return secretType;
					}
					set	
					{
						secretType = value;
					}
				}

				public string SecretData
				{
					get
					{
						return secretData;
					}
					set	
					{
						secretData = value;
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

				public long? UpdateTime
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

				public List<ListSecrets_RelateApp> RelateApps
				{
					get
					{
						return relateApps;
					}
					set	
					{
						relateApps = value;
					}
				}

				public class ListSecrets_RelateApp
				{

					private string appName;

					private string appId;

					public string AppName
					{
						get
						{
							return appName;
						}
						set	
						{
							appName = value;
						}
					}

					public string AppId
					{
						get
						{
							return appId;
						}
						set	
						{
							appId = value;
						}
					}
				}
			}
		}
	}
}
