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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class RenewInstanceRequest : RpcAcsRequest<RenewInstanceResponse>
    {
        public RenewInstanceRequest()
            : base("Ecs", "2014-05-26", "RenewInstance")
        {
        }

	private long? ownerId;

	private string resourceOwnerAccount;

	private long? resourceOwnerId;

	private string ownerAccount;

	private string instanceId;

	private string instanceType;

	private int? internetMaxBandwidthOut;

	private string internetChargeType;

	private int? period;

	private string rebootTime;

	private string covertDiskPortable1DiskId;

	private string covertDiskPortable2DiskId;

	private string covertDiskPortable3DiskId;

	private string covertDiskPortable4DiskId;

	public long? OwnerId
	{
		get
		{
			return ownerId;
		}
		set	
		{
			ownerId = value;
			DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
		}
	}

	public string ResourceOwnerAccount
	{
		get
		{
			return resourceOwnerAccount;
		}
		set	
		{
			resourceOwnerAccount = value;
			DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
		}
	}

	public long? ResourceOwnerId
	{
		get
		{
			return resourceOwnerId;
		}
		set	
		{
			resourceOwnerId = value;
			DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
		}
	}

	public string OwnerAccount
	{
		get
		{
			return ownerAccount;
		}
		set	
		{
			ownerAccount = value;
			DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
		}
	}

	public string InstanceId
	{
		get
		{
			return instanceId;
		}
		set	
		{
			instanceId = value;
			DictionaryUtil.Add(QueryParameters, "InstanceId", value);
		}
	}

	public string InstanceType
	{
		get
		{
			return instanceType;
		}
		set	
		{
			instanceType = value;
			DictionaryUtil.Add(QueryParameters, "InstanceType", value);
		}
	}

	public int? InternetMaxBandwidthOut
	{
		get
		{
			return internetMaxBandwidthOut;
		}
		set	
		{
			internetMaxBandwidthOut = value;
			DictionaryUtil.Add(QueryParameters, "InternetMaxBandwidthOut", value.ToString());
		}
	}

	public string InternetChargeType
	{
		get
		{
			return internetChargeType;
		}
		set	
		{
			internetChargeType = value;
			DictionaryUtil.Add(QueryParameters, "InternetChargeType", value);
		}
	}

	public int? Period
	{
		get
		{
			return period;
		}
		set	
		{
			period = value;
			DictionaryUtil.Add(QueryParameters, "Period", value.ToString());
		}
	}

	public string RebootTime
	{
		get
		{
			return rebootTime;
		}
		set	
		{
			rebootTime = value;
			DictionaryUtil.Add(QueryParameters, "RebootTime", value);
		}
	}

	public string CovertDiskPortable1DiskId
	{
		get
		{
			return covertDiskPortable1DiskId;
		}
		set	
		{
			covertDiskPortable1DiskId = value;
			DictionaryUtil.Add(QueryParameters, "CovertDiskPortable.1.DiskId", value);
		}
	}

	public string CovertDiskPortable2DiskId
	{
		get
		{
			return covertDiskPortable2DiskId;
		}
		set	
		{
			covertDiskPortable2DiskId = value;
			DictionaryUtil.Add(QueryParameters, "CovertDiskPortable.2.DiskId", value);
		}
	}

	public string CovertDiskPortable3DiskId
	{
		get
		{
			return covertDiskPortable3DiskId;
		}
		set	
		{
			covertDiskPortable3DiskId = value;
			DictionaryUtil.Add(QueryParameters, "CovertDiskPortable.3.DiskId", value);
		}
	}

	public string CovertDiskPortable4DiskId
	{
		get
		{
			return covertDiskPortable4DiskId;
		}
		set	
		{
			covertDiskPortable4DiskId = value;
			DictionaryUtil.Add(QueryParameters, "CovertDiskPortable.4.DiskId", value);
		}
	}

        public override RenewInstanceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return RenewInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}