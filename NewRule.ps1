$firewallRuleName = "ZhengHuo"
$gamePath = "C:\Program Files (x86)\Hearthstone - Copy\Hearthstone.exe"

write-host "Checking for '$firewallRuleName' firewall rule on port '$firewallPort' now...."
if ($(Get-NetFirewallRule –DisplayName $firewallRuleName ))
{
    write-host "Firewall rule for '$firewallRuleName' already exists, not creating new rule"
}
else
{
    write-host "Firewall rule for '$firewallRuleName' does not already exist, creating new rule now..."
    New-NetFirewallRule -DisplayName $firewallRuleName -Direction Inbound -Profile Domain,Private,Public -Action Allow -Protocol TCP -RemoteAddress Any
    write-host "Firewall rule for '$firewallRuleName' created successfully"
}