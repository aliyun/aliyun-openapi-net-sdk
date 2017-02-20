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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
	public class DescribeDeployedApiResponse : AcsResponse
	{
	    public string RegionId { get; set; }

	    public string GroupId { get; set; }

	    public string GroupName { get; set; }

	    public string StageName { get; set; }

	    public string ApiId { get; set; }

	    public string ApiName { get; set; }

	    public string Description { get; set; }

	    public string Visibility { get; set; }

	    public string AuthType { get; set; }

	    public string ResultType { get; set; }

	    public string ResultSample { get; set; }

	    public string FailResultSample { get; set; }

	    public string DeployedTime { get; set; }

	    public List<ErrorCodeSample> ErrorCodeSamples { get; set; }

	    public List<SystemParameter> SystemParameters { get; set; }

	    public List<ConstantParameter> ConstantParameters { get; set; }

	    public List<RequestParameter> RequestParameters { get; set; }

	    public List<ServiceParameter> ServiceParameters { get; set; }

	    public List<ServiceParameterMap> ServiceParametersMap { get; set; }

	    public RequestConfig_ RequestConfig { get; set; }

	    public ServiceConfig_ ServiceConfig { get; set; }

	    public class ErrorCodeSample{
	        public string Code { get; set; }

	        public string Message { get; set; }

	        public string Description { get; set; }
	    }

		public class SystemParameter{
		    public string ParameterName { get; set; }

		    public string ServiceParameterName { get; set; }

		    public string Location { get; set; }

		    public string DemoValue { get; set; }

		    public string Description { get; set; }
		}

		public class ConstantParameter{
		    public string ServiceParameterName { get; set; }

		    public string ConstantValue { get; set; }

		    public string Location { get; set; }

		    public string Description { get; set; }
		}

		public class RequestParameter{
		    public string ApiParameterName { get; set; }

		    public string Location { get; set; }

		    public string ParameterType { get; set; }

		    public string Required { get; set; }

		    public string DefaultValue { get; set; }

		    public string DemoValue { get; set; }

		    public long? MaxValue { get; set; }

		    public long? MinValue { get; set; }

		    public long? MaxLength { get; set; }

		    public long? MinLength { get; set; }

		    public string RegularExpression { get; set; }

		    public string JsonScheme { get; set; }

		    public string EnumValue { get; set; }

		    public string DocShow { get; set; }

		    public int? DocOrder { get; set; }

		    public string Description { get; set; }
		}

		public class ServiceParameter{
		    public string ServiceParameterName { get; set; }

		    public string Location { get; set; }

		    public string ParameterType { get; set; }
		}

		public class ServiceParameterMap{
		    public string ServiceParameterName { get; set; }

		    public string RequestParameterName { get; set; }
		}

		public class RequestConfig_{
		    public string RequestProtocol { get; set; }

		    public string RequestHttpMethod { get; set; }

		    public string RequestPath { get; set; }

		    public string BodyFormat { get; set; }

		    public string PostBodyDescription { get; set; }
		}

		public class ServiceConfig_{
		    public string ServiceProtocol { get; set; }

		    public string ServiceAddress { get; set; }

		    public string ServiceHttpMethod { get; set; }

		    public string ServicePath { get; set; }

		    public int? ServiceTimeout { get; set; }
		}
	}
}