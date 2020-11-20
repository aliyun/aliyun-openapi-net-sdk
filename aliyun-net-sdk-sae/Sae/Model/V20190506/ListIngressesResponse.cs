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

namespace Aliyun.Acs.sae.Model.V20190506
{
	public class ListIngressesResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private bool? success;

		private string errorCode;

		private string traceId;

		private ListIngresses_Data data;

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

		public ListIngresses_Data Data
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

		public class ListIngresses_Data
		{

			private List<ListIngresses_Ingress> ingressList;

			public List<ListIngresses_Ingress> IngressList
			{
				get
				{
					return ingressList;
				}
				set	
				{
					ingressList = value;
				}
			}

			public class ListIngresses_Ingress
			{

				private long? id;

				private string name;

				private string namespaceId;

				private string slbId;

				private string listenerPort;

				private string certId;

				private string description;

				private string slbType;

				public long? Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
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

				public string SlbId
				{
					get
					{
						return slbId;
					}
					set	
					{
						slbId = value;
					}
				}

				public string ListenerPort
				{
					get
					{
						return listenerPort;
					}
					set	
					{
						listenerPort = value;
					}
				}

				public string CertId
				{
					get
					{
						return certId;
					}
					set	
					{
						certId = value;
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

				public string SlbType
				{
					get
					{
						return slbType;
					}
					set	
					{
						slbType = value;
					}
				}
			}
		}
	}
}
