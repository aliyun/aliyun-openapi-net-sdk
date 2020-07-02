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
using Aliyun.Acs.dataworks_public.Transform;
using Aliyun.Acs.dataworks_public.Transform.V20200518;

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
    public class UpdateUdfFileRequest : RpcAcsRequest<UpdateUdfFileResponse>
    {
        public UpdateUdfFileRequest()
            : base("dataworks-public", "2020-05-18", "UpdateUdfFile", "dide", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string returnValue;

		private string resources;

		private string functionType;

		private string cmdDescription;

		private string udfDescription;

		private string parameterDescription;

		private string projectIdentifier;

		private string example;

		private string className;

		private string fileFolderPath;

		private long? projectId;

		private string fileId;

		public string ReturnValue
		{
			get
			{
				return returnValue;
			}
			set	
			{
				returnValue = value;
				DictionaryUtil.Add(BodyParameters, "ReturnValue", value);
			}
		}

		public string Resources
		{
			get
			{
				return resources;
			}
			set	
			{
				resources = value;
				DictionaryUtil.Add(BodyParameters, "Resources", value);
			}
		}

		public string FunctionType
		{
			get
			{
				return functionType;
			}
			set	
			{
				functionType = value;
				DictionaryUtil.Add(BodyParameters, "FunctionType", value);
			}
		}

		public string CmdDescription
		{
			get
			{
				return cmdDescription;
			}
			set	
			{
				cmdDescription = value;
				DictionaryUtil.Add(BodyParameters, "CmdDescription", value);
			}
		}

		public string UdfDescription
		{
			get
			{
				return udfDescription;
			}
			set	
			{
				udfDescription = value;
				DictionaryUtil.Add(BodyParameters, "UdfDescription", value);
			}
		}

		public string ParameterDescription
		{
			get
			{
				return parameterDescription;
			}
			set	
			{
				parameterDescription = value;
				DictionaryUtil.Add(BodyParameters, "ParameterDescription", value);
			}
		}

		public string ProjectIdentifier
		{
			get
			{
				return projectIdentifier;
			}
			set	
			{
				projectIdentifier = value;
				DictionaryUtil.Add(BodyParameters, "ProjectIdentifier", value);
			}
		}

		public string Example
		{
			get
			{
				return example;
			}
			set	
			{
				example = value;
				DictionaryUtil.Add(BodyParameters, "Example", value);
			}
		}

		public string ClassName
		{
			get
			{
				return className;
			}
			set	
			{
				className = value;
				DictionaryUtil.Add(BodyParameters, "ClassName", value);
			}
		}

		public string FileFolderPath
		{
			get
			{
				return fileFolderPath;
			}
			set	
			{
				fileFolderPath = value;
				DictionaryUtil.Add(BodyParameters, "FileFolderPath", value);
			}
		}

		public long? ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(BodyParameters, "ProjectId", value.ToString());
			}
		}

		public string FileId
		{
			get
			{
				return fileId;
			}
			set	
			{
				fileId = value;
				DictionaryUtil.Add(BodyParameters, "FileId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateUdfFileResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateUdfFileResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
