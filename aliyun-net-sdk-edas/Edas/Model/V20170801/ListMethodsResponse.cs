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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class ListMethodsResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private List<ListMethods_ServiceMethod> serviceMethodList;

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

		public List<ListMethods_ServiceMethod> ServiceMethodList
		{
			get
			{
				return serviceMethodList;
			}
			set	
			{
				serviceMethodList = value;
			}
		}

		public class ListMethods_ServiceMethod
		{

			private string appName;

			private string serviceName;

			private string methodName;

			private string output;

			private List<string> inputParams;

			private List<string> paramTypes;

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

			public string ServiceName
			{
				get
				{
					return serviceName;
				}
				set	
				{
					serviceName = value;
				}
			}

			public string MethodName
			{
				get
				{
					return methodName;
				}
				set	
				{
					methodName = value;
				}
			}

			public string Output
			{
				get
				{
					return output;
				}
				set	
				{
					output = value;
				}
			}

			public List<string> InputParams
			{
				get
				{
					return inputParams;
				}
				set	
				{
					inputParams = value;
				}
			}

			public List<string> ParamTypes
			{
				get
				{
					return paramTypes;
				}
				set	
				{
					paramTypes = value;
				}
			}
		}
	}
}
