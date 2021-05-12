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
using Aliyun.Acs.dataworks_public;
using Aliyun.Acs.dataworks_public.Transform;
using Aliyun.Acs.dataworks_public.Transform.V20200518;

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
    public class UpdateFileRequest : RpcAcsRequest<UpdateFileResponse>
    {
        public UpdateFileRequest()
            : base("dataworks-public", "2020-05-18", "UpdateFile")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string outputList;

		private string dependentNodeIdList;

		private string content;

		private string projectIdentifier;

		private long? projectId;

		private long? startEffectDate;

		private string cycleType;

		private long? fileId;

		private int? autoRerunIntervalMillis;

		private string owner;

		private string inputList;

		private string rerunMode;

		private string connectionName;

		private string paraValue;

		private string resourceGroupIdentifier;

		private int? autoRerunTimes;

		private string cronExpress;

		private long? endEffectDate;

		private string fileName;

		private bool? stop;

		private string dependentType;

		private string fileFolderPath;

		private string fileDescription;

		public string OutputList
		{
			get
			{
				return outputList;
			}
			set	
			{
				outputList = value;
				DictionaryUtil.Add(BodyParameters, "OutputList", value);
			}
		}

		public string DependentNodeIdList
		{
			get
			{
				return dependentNodeIdList;
			}
			set	
			{
				dependentNodeIdList = value;
				DictionaryUtil.Add(BodyParameters, "DependentNodeIdList", value);
			}
		}

		public string Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
				DictionaryUtil.Add(BodyParameters, "Content", value);
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

		public long? StartEffectDate
		{
			get
			{
				return startEffectDate;
			}
			set	
			{
				startEffectDate = value;
				DictionaryUtil.Add(BodyParameters, "StartEffectDate", value.ToString());
			}
		}

		public string CycleType
		{
			get
			{
				return cycleType;
			}
			set	
			{
				cycleType = value;
				DictionaryUtil.Add(BodyParameters, "CycleType", value);
			}
		}

		public long? FileId
		{
			get
			{
				return fileId;
			}
			set	
			{
				fileId = value;
				DictionaryUtil.Add(BodyParameters, "FileId", value.ToString());
			}
		}

		public int? AutoRerunIntervalMillis
		{
			get
			{
				return autoRerunIntervalMillis;
			}
			set	
			{
				autoRerunIntervalMillis = value;
				DictionaryUtil.Add(BodyParameters, "AutoRerunIntervalMillis", value.ToString());
			}
		}

		public string Owner
		{
			get
			{
				return owner;
			}
			set	
			{
				owner = value;
				DictionaryUtil.Add(BodyParameters, "Owner", value);
			}
		}

		public string InputList
		{
			get
			{
				return inputList;
			}
			set	
			{
				inputList = value;
				DictionaryUtil.Add(BodyParameters, "InputList", value);
			}
		}

		public string RerunMode
		{
			get
			{
				return rerunMode;
			}
			set	
			{
				rerunMode = value;
				DictionaryUtil.Add(BodyParameters, "RerunMode", value);
			}
		}

		public string ConnectionName
		{
			get
			{
				return connectionName;
			}
			set	
			{
				connectionName = value;
				DictionaryUtil.Add(BodyParameters, "ConnectionName", value);
			}
		}

		public string ParaValue
		{
			get
			{
				return paraValue;
			}
			set	
			{
				paraValue = value;
				DictionaryUtil.Add(BodyParameters, "ParaValue", value);
			}
		}

		public string ResourceGroupIdentifier
		{
			get
			{
				return resourceGroupIdentifier;
			}
			set	
			{
				resourceGroupIdentifier = value;
				DictionaryUtil.Add(BodyParameters, "ResourceGroupIdentifier", value);
			}
		}

		public int? AutoRerunTimes
		{
			get
			{
				return autoRerunTimes;
			}
			set	
			{
				autoRerunTimes = value;
				DictionaryUtil.Add(BodyParameters, "AutoRerunTimes", value.ToString());
			}
		}

		public string CronExpress
		{
			get
			{
				return cronExpress;
			}
			set	
			{
				cronExpress = value;
				DictionaryUtil.Add(BodyParameters, "CronExpress", value);
			}
		}

		public long? EndEffectDate
		{
			get
			{
				return endEffectDate;
			}
			set	
			{
				endEffectDate = value;
				DictionaryUtil.Add(BodyParameters, "EndEffectDate", value.ToString());
			}
		}

		public string FileName
		{
			get
			{
				return fileName;
			}
			set	
			{
				fileName = value;
				DictionaryUtil.Add(BodyParameters, "FileName", value);
			}
		}

		public bool? Stop
		{
			get
			{
				return stop;
			}
			set	
			{
				stop = value;
				DictionaryUtil.Add(BodyParameters, "Stop", value.ToString());
			}
		}

		public string DependentType
		{
			get
			{
				return dependentType;
			}
			set	
			{
				dependentType = value;
				DictionaryUtil.Add(BodyParameters, "DependentType", value);
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

		public string FileDescription
		{
			get
			{
				return fileDescription;
			}
			set	
			{
				fileDescription = value;
				DictionaryUtil.Add(BodyParameters, "FileDescription", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateFileResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateFileResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
