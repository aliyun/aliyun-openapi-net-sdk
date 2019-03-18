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

namespace Aliyun.Acs.afs.Model.V20180112
{
	public class ConfigurationStyleResponse : AcsResponse
	{

		private string requestId;

		private string bizCode;

		private ConfigurationStyle_CodeData codeData;

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

		public string BizCode
		{
			get
			{
				return bizCode;
			}
			set	
			{
				bizCode = value;
			}
		}

		public ConfigurationStyle_CodeData CodeData
		{
			get
			{
				return codeData;
			}
			set	
			{
				codeData = value;
			}
		}

		public class ConfigurationStyle_CodeData
		{

			private string html;

			private string net;

			private string php;

			private string python;

			private string java;

			private string nodeJs;

			private string netUrl;

			private string phpUrl;

			private string pythonUrl;

			private string javaUrl;

			private string nodeJsUrl;

			public string Html
			{
				get
				{
					return html;
				}
				set	
				{
					html = value;
				}
			}

			public string Net
			{
				get
				{
					return net;
				}
				set	
				{
					net = value;
				}
			}

			public string Php
			{
				get
				{
					return php;
				}
				set	
				{
					php = value;
				}
			}

			public string Python
			{
				get
				{
					return python;
				}
				set	
				{
					python = value;
				}
			}

			public string Java
			{
				get
				{
					return java;
				}
				set	
				{
					java = value;
				}
			}

			public string NodeJs
			{
				get
				{
					return nodeJs;
				}
				set	
				{
					nodeJs = value;
				}
			}

			public string NetUrl
			{
				get
				{
					return netUrl;
				}
				set	
				{
					netUrl = value;
				}
			}

			public string PhpUrl
			{
				get
				{
					return phpUrl;
				}
				set	
				{
					phpUrl = value;
				}
			}

			public string PythonUrl
			{
				get
				{
					return pythonUrl;
				}
				set	
				{
					pythonUrl = value;
				}
			}

			public string JavaUrl
			{
				get
				{
					return javaUrl;
				}
				set	
				{
					javaUrl = value;
				}
			}

			public string NodeJsUrl
			{
				get
				{
					return nodeJsUrl;
				}
				set	
				{
					nodeJsUrl = value;
				}
			}
		}
	}
}
